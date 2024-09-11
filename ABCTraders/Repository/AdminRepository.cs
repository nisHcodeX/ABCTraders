using ABCTraders.DbConection;
using ABCTraders.Dto;
using ABCTraders.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static ABCTraders.Common.AbcEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public int UpdateCarToSystem(int id, AddCarDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"UPDATE Cars SET VIN = @VIN, Transmission = @Transmission, Year = @Year, FuelType = @FuelType, Color = @Color, Price = @Price, Condition = @Condition, Description = @Description, Picture = @Picture, ModelId = @ModelId, ManufacturerId = @ManufacturerId, UpdatedAt=GETDATE() WHERE Id = @Id";

                        command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
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
                        command.CommandText = @"SELECT C.*, M.Name AS ModelName, MN.Name AS ManufacturerName FROM Cars C INNER JOIN Models M on C.ModelId = M.Id INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE C.Status = 0 AND C.IsActive = 1";

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
                                ModelId = Convert.ToInt32(reader["ModelId"].ToString()),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                                Picture = (byte[])reader["picture"]
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

        public List<CarDetailsModel> GetAllCarsByStatus(int status)
        {
            try
            {
                var carList = new List<CarDetailsModel>();

                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.CommandText = @"SELECT C.*, M.Name AS ModelName, MN.Name AS ManufacturerName FROM Cars C INNER JOIN Models M on C.ModelId = M.Id INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE C.IsActive = @status";

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
                                ModelId = Convert.ToInt32(reader["ModelId"].ToString()),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                                Picture = (byte[])reader["picture"],
                                Status = Convert.ToInt32(reader["Status"].ToString()),
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

        public CarDetailsModel GetCarByVin(string vin)
        {
            try
            {
                CarDetailsModel carResult = null;

                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@VIN", vin);
                        command.CommandText = @"SELECT C.*, M.Name AS ModelName, MN.Name AS ManufacturerName FROM Cars C INNER JOIN Models M on C.ModelId = M.Id INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE C.VIN =@vin and C.IsActive = 1";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            carResult = new CarDetailsModel
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
                                ModelId = Convert.ToInt32(reader["ModelId"].ToString()),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                                Picture = (byte[])reader["picture"]
                            };
                           return carResult;
                        }
                    }
                    connection.Close();
                }
                return carResult;
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

        public List<AddCarPartDetailModel> GetAllCarParts()
        {
            try
            {
                var carPartsList = new List<AddCarPartDetailModel>();

                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT C.*, MN.Name AS ManufacturerName FROM CarParts C INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE C.Status = 0 and IsActive = 1";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new AddCarPartDetailModel
                            {
                                Id = Convert.ToInt32(reader["ID"].ToString()),
                                PartName = reader["PartName"].ToString(),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                                PartCode = reader["PartCode"].ToString(),
                                Category = reader["Category"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"].ToString()),
                                Condition = (CarCondition)Convert.ToInt32(reader["Condition"].ToString()),
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"].ToString()),
                                ImagePath = (byte[])reader["picture"],
                                ManufacturerName = reader["ManufacturerName"].ToString(),
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

        public List<AddCarPartDetailModel> GetAllCarPartsByStatus(int status)
        {
            try
            {
                var carPartsList = new List<AddCarPartDetailModel>();

                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.CommandText = @"SELECT C.*, MN.Name AS ManufacturerName FROM CarParts C INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE IsActive = @status";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new AddCarPartDetailModel
                            {
                                Id = Convert.ToInt32(reader["ID"].ToString()),
                                PartName = reader["PartName"].ToString(),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                                PartCode = reader["PartCode"].ToString(),
                                Category = reader["Category"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"].ToString()),
                                Condition = (CarCondition)Convert.ToInt32(reader["Condition"].ToString()),
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"].ToString()),
                                ImagePath = (byte[])reader["picture"],
                                ManufacturerName = reader["ManufacturerName"].ToString(),
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

        public AddCarPartDetailModel GetCarPartByPartCode(string code)
        {
            try
            {
                AddCarPartDetailModel carPartResult = null;

                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@PartCode", code);
                        command.CommandText = @"SELECT C.*, MN.Name AS ManufacturerName FROM CarParts C INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE C.PartCode = @PartCode AND C.IsActive = 1";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            carPartResult = new AddCarPartDetailModel
                            {
                                Id = Convert.ToInt32(reader["ID"].ToString()),
                                PartName = reader["PartName"].ToString(),
                                ManufacturerId = Convert.ToInt32(reader["ManufacturerId"].ToString()),
                                PartCode = reader["PartCode"].ToString(),
                                Category = reader["Category"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"].ToString()),
                                Condition = (CarCondition)Convert.ToInt32(reader["Condition"].ToString()),
                                StockQuantity = Convert.ToInt32(reader["StockQuantity"].ToString()),
                                ImagePath = (byte[])reader["picture"],
                                ManufacturerName = reader["ManufacturerName"].ToString(),
                            };
                            return carPartResult;
                        }
                    }
                    connection.Close();
                }
                return carPartResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
                        command.CommandText = @"INSERT INTO CarParts(PartName, ManufacturerId, PartCode, Category, Description, Price, Condition, StockQuantity, Picture, IsActive, CreatedDate, Status, UpdatedAt)
                        VALUES(@PartName, @ManufacturerId, @PartCode, @Category, @Description, @Price, @Condition, @StockQuantity, @Picture, 1, GETDATE(), 0, GETDATE())";

                        command.Parameters.Add("@PartName", SqlDbType.NVarChar).Value = dto.PartName;
                        command.Parameters.Add("@ManufacturerId", SqlDbType.Int).Value = dto.ManufacturerId;
                        command.Parameters.Add("@PartCode", SqlDbType.NVarChar).Value = dto.PartCode;
                        command.Parameters.Add("@Category", SqlDbType.Int).Value = dto.Category;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = dto.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.Price;
                        command.Parameters.Add("@Condition", SqlDbType.Int).Value = dto.Condition;
                        command.Parameters.Add("@StockQuantity", SqlDbType.Int).Value = dto.StockQuantity;
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = dto.ImagePath;


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

        public int UpdateCarPartToSystem(int id, AddCarPartDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"UPDATE CarParts SET PartName = @PartName, ManufacturerId = @ManufacturerId, PartCode = @PartCode, Category = @Category, Description = @Description, Price = @Price, Condition = @Condition, StockQuantity = @StockQuantity, Picture = @Picture, UpdatedAt=GETDATE() WHERE Id = @Id";

                        command.Parameters.Add("@PartName", SqlDbType.NVarChar).Value = dto.PartName;
                        command.Parameters.Add("@ManufacturerId", SqlDbType.Int).Value = dto.ManufacturerId;
                        command.Parameters.Add("@PartCode", SqlDbType.NVarChar).Value = dto.PartCode;
                        command.Parameters.Add("@Category", SqlDbType.Int).Value = dto.Category;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = dto.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.Price;
                        command.Parameters.Add("@Condition", SqlDbType.Int).Value = dto.Condition;
                        command.Parameters.Add("@StockQuantity", SqlDbType.Int).Value = dto.StockQuantity;
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = dto.ImagePath;
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

        public int DeleteCarById(int carId)
        {
            int id = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = carId;
                        command.CommandText = @"UPDATE Cars SET IsActive = 0, UpdatedAt = GETDATE() WHERE Id = @Id;";

                        var reader = command.ExecuteReader();
                     }
                    connection.Close();
                }
                return id = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return id;
            }
        }

        public int DeleteCarPartById(int partId)
        {
            int id = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = partId;
                        command.CommandText = @"UPDATE CarParts SET IsActive = 0, UpdatedAt = GETDATE() WHERE Id = @Id;";

                        var reader = command.ExecuteReader();
                    }
                    connection.Close();
                }
                return id = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return id;
            }
        }

        public int UpdateCustomerByAdmin(int customerId, CustomerDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@Id", customerId);
                        command.CommandText = @"UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Address = @Address, IsActive=@IsActive, UpdatedAt = GETDATE()
                        WHERE Id = @Id;";

                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = dto.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = dto.LastName;
                        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dto.Address;
                        command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = dto.Contact;
                        command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;

                        var reader = command.ExecuteReader();
                    }
                    connection.Close();
                }

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int UpdateCarPartStatus(int partId, int status)
        {
            try{
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@Id", partId);
                        command.Parameters.AddWithValue("@Status", status);
                        command.CommandText = @"UPDATE CarParts SET Status = @Status, UpdatedAt= GETDATE() WHERE Id = @Id";

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

        public int UpdateCarPartStock(int partId, int StockQuantity){
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@Id", partId);
                        command.Parameters.AddWithValue("@StockQuantity", StockQuantity);
                        command.CommandText = @"UPDATE CarParts SET StockQuantity = @StockQuantity, UpdatedAt= GETDATE() WHERE Id = @Id";

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

        public int UpdateCarStatus(int carId, int status)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@Id", carId);
                        command.Parameters.AddWithValue("@Status", status);
                        command.CommandText = @"UPDATE Cars SET Status = @Status, UpdatedAt=GETDATE() WHERE Id = @Id";

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
    }
}
