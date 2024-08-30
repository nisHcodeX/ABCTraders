using ABCTraders.DbConection;
using ABCTraders.Dto;
using ABCTraders.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Repository
{
    internal class AdminRepository: DbConnection
    {
        public AdminModel getAdminByEmail(string email)
        {
            AdminModel admin = null;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM Admin WHERE Email = @Email AND IsActive = 1"; ;
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                        var reader = command.ExecuteReader();
                            
                            while (reader.Read())
                            {
                                admin = new AdminModel
                                {
                                    Id = Convert.ToInt32(reader["ID"]),
                                    Email = reader["Email"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                                    PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : null
                                };
                             }
                    }
                    connection.Close();
                    if (admin != null)
                    {
                        connection.Open();
                        using (var updateCommand = connection.CreateCommand())
                        {
                            updateCommand.CommandText = "UPDATE Admin SET LastLoginDate = @LastLoginDate WHERE Email = @Email";
                            updateCommand.Parameters.Add("@LastLoginDate", SqlDbType.DateTime).Value = DateTime.Now;
                            updateCommand.Parameters.Add("email", SqlDbType.NVarChar).Value= email;
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    connection.Close();  
                }
            }
            catch (Exception)
            {
                return admin;
                //throw new Exception("Error retrieving admin by email", ex);
            }

            return admin;
        }
        public int AddCarToSystem(AddCarDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO Cars(VIN, Transmission, Year, FuelType, Color, Price, Condition, Description, Status, IsActive, CreatedDate, Picture, ModelId, ManufacturerId)
                        VALUES(@VIN, @Transmission, @Year, @FuelType, @Color, @Price, @Condition, @Description, 0, 1, GETDATE(), @Picture, @ModelId, @ManufacturerId)";

                        command.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = dto.VIN;
                        command.Parameters.Add("@Transmission", SqlDbType.Int).Value = dto.Transmission;
                        command.Parameters.Add("@Year", SqlDbType.Int).Value = dto.Year;
                        command.Parameters.Add("@FuelType", SqlDbType.Int).Value = dto.FuelType;
                        command.Parameters.Add("@Color", SqlDbType.Int).Value = dto.Color;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.Price;
                        command.Parameters.Add("@Condition", SqlDbType.Int).Value = dto.Condition;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = dto.Description;
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = dto.Picture;
                        command.Parameters.Add("@ModelId", SqlDbType.Int).Value = dto.ModelId;
                        command.Parameters.Add("@ManufacturerId", SqlDbType.Int).Value = dto.ManufacturerId;


                        var reader = command.ExecuteReader();
                    }
                    connection.Close();
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int AddCarPartToSystem(AddCarPartDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO AddCarPart(PartName, Manufacturer, PartCode, Category, Description, Price, Condition, StockQuantity, ImagePath, IsActive, CreatedDate, LastLoginDate)
                        VALUES(@PartName, @Manufacturer, @PartCode, @Category, @Description, @Price, @Condition, @StockQuantity, @ImagePath, 1, GETDATE(), GETDATE())";

                        command.Parameters.Add("@PartName", SqlDbType.NVarChar).Value = dto.PartName;
                        command.Parameters.Add("@Manufacturer", SqlDbType.NVarChar).Value = dto.Manufacturer;
                        command.Parameters.Add("@PartCode", SqlDbType.NVarChar).Value = dto.PartCode;
                        command.Parameters.Add("@Category", SqlDbType.NVarChar).Value = dto.Category;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = dto.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.Price;
                        command.Parameters.Add("@Condition", SqlDbType.Int).Value = dto.Condition;
                        command.Parameters.Add("@StockQuantity", SqlDbType.Int).Value = dto.StockQuantity;
                        command.Parameters.Add("@ImagePath", SqlDbType.Image).Value = dto.ImagePath;


                        var reader = command.ExecuteReader();
                    }
                    connection.Close();
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<CarDetailsModel> GetAllCars()
        {
            try
            {
                var carList = new List<CarDetailsModel>();

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT C.*, M.Name AS ModelName, MN.Name AS ManufacturerName FROM Cars C INNER JOIN Models M on C.ModelId = M.Id INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new CarDetailsModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                VIN = reader["VIN"].ToString(),
                                Transmission = (Transmission)Convert.ToInt32(reader["Transmission"].ToString()),
                                Year = Convert.ToInt32(reader["Year"].ToString()),
                                FuelType = (FuelTypes)Convert.ToInt32(reader["FuelType"].ToString()),
                                Color = (CarColors)Convert.ToInt32(reader["Color"].ToString()),
                                Price = Convert.ToDecimal(reader["Price"].ToString()),
                                Condition = (CarCondition)Convert.ToInt32(reader["Condition"].ToString()),
                                Description = reader["Description"].ToString(),
                                ModelName = reader["ModelName"].ToString(),
                                ManufacturerName = reader["ManufacturerName"].ToString(),
                            };
                            carList.Add(car);
                        }
                    }
                    connection.Close();
                }
                return carList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<AddCarPartModel> GetAllCarParts()
        {
            try
            {
                var carPartsList = new List<AddCarPartModel>();

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM AddCarPart WHERE IsActive = 1";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new AddCarPartModel
                            {
                                Id = Convert.ToInt32(reader["ID"].ToString()),
                                PartName = reader["PartName"].ToString(),
                                Manufacturer = reader["Manufacturer"].ToString(),
                                PartCode = reader["PartCode"].ToString(),
                                Category = reader["Category"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"].ToString()),
                                Condition = (CarCondition)Convert.ToInt32(reader["Condition"].ToString()),
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"].ToString()),
                            };
                            carPartsList.Add(car);
                        }
                    }
                    connection.Close();
                }
                return carPartsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            try
            {
                var list = new List<Manufacturer>();

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM Manufacturers";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new Manufacturer
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Name = reader["Name"].ToString(),
                            };
                            list.Add(car);
                        }
                    }
                    connection.Close();
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<CarModel> GetAllModels(int manufactureId)
        {
            try
            {
                var list = new List<CarModel>();

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $@"SELECT * FROM Models WHERE ManufacturerId = {manufactureId}";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var model = new CarModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Name = reader["Name"].ToString(),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                            };
                            list.Add(model);
                        }
                    }
                    connection.Close();
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
