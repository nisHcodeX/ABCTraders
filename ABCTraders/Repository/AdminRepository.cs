using ABCTraders.DbConection;
using ABCTraders.Dto;
using ABCTraders.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Email = reader["Email"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                    LastLoginDate = reader["LastLoginDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["LastLoginDate"]) : (DateTime?)null,
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
                        command.CommandText = @"INSERT INTO AddCar(Model, Manufacturer, VIN, Transmission, Year, FuelType, Color, Price, Condition, Description, Status, IsActive, CreatedDate, LastLoginDate, ImagePath)
                        VALUES(@Model, @Manufacturer, @VIN, @Transmission, @Year, @FuelType, @Color, @Price, @Condition, @Description, 0, 1, GETDATE(), GETDATE(), @ImagePath)";

                        command.Parameters.Add("@Model", SqlDbType.NVarChar).Value = dto.Model;
                        command.Parameters.Add("@Manufacturer", SqlDbType.NVarChar).Value = dto.Manufacturer;
                        command.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = dto.VIN;
                        command.Parameters.Add("@Transmission", SqlDbType.NVarChar).Value = dto.Transmission;
                        command.Parameters.Add("@Year", SqlDbType.Int).Value = dto.Year;
                        command.Parameters.Add("@FuelType", SqlDbType.Int).Value = dto.FuelType;
                        command.Parameters.Add("@Color", SqlDbType.NVarChar).Value = dto.Color;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.Price;
                        command.Parameters.Add("@Condition", SqlDbType.NVarChar).Value = dto.Condition;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = dto.Description;
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
    }
}
