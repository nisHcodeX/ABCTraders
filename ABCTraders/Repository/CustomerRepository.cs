using ABCTraders.DbConection;
using ABCTraders.Dto;
using ABCTraders.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABCTraders.Common.AbcEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABCTraders.Repository
{
    internal class CustomerRepository : DbConnection
    {
        public CustomerModel GetCustomerByEmail(string email)
        {
            CustomerModel customer = null;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM Customers WHERE Email = @Email AND IsActive = 1";
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            customer = new CustomerModel
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Email = reader["Email"].ToString(),
                                Password = reader["Password"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                Contact = reader["Contact"].ToString()
                            };
                        }
                    }
                    connection.Close();
                }
                return customer;
            } catch (Exception) {
                return customer;
            }
        }

        public int CreateCustomer(CustomerDto dto)
        {
            try
            {
                using(var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO Customers(FirstName, LastName, Email, Address, Contact, Password, IsActive, UserType,  CreatedDate, LastLoginDate)
                        VALUES(@FirstName, @LastName, @Email, @Address, @Contact, @Password, 1, 0, GETDATE(), GETDATE())";

                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = dto.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = dto.LastName;
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = dto.Email;
                        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dto.Address;
                        command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = dto.Contact;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = dto.Password;

                        var reader = command.ExecuteReader();
                    }
                    connection.Close();
                }
                return 1;
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<CustomerModel> GetAllCustomers()
        {
            try
            {
                var carList = new List<CustomerModel>();

                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM Customers";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new CustomerModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Email = reader["Email"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                Contact = reader["Contact"].ToString(),
                                Password = reader["Password"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
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

        public int UpdateCustomer(int customerId, CustomerModel dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@Id", customerId);
                        command.CommandText = @"UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Address = @Address, UpdatedAt = GETDATE()
                        WHERE Id = @Id;";

                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = dto.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = dto.LastName;
                        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dto.Address;
                        command.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = dto.Contact;

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


        public int UpdateCustomerPassword(int id, string password)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"UPDATE Customers SET Password = @Password, UpdatedAt = GETDATE() WHERE Id = @Id;";
                        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

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

        public List<AddCarPartDetailModel> SearchCarPartInSystem( int status, string searchKey)
        {
            List<AddCarPartDetailModel> carPartsList = new List<AddCarPartDetailModel>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = command.CommandText = @"SELECT C.*, MN.Name AS ManufacturerName FROM CarParts C INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id  WHERE C.PartName LIKE '%' + @key + '%' AND C.Status = @Status AND C.IsActive = 1;";

                        command.Parameters.Add("@Key", SqlDbType.VarChar).Value = searchKey;
                        command.Parameters.Add("@Status", SqlDbType.Int).Value = status;

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var part = new AddCarPartDetailModel
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
                            carPartsList.Add(part);
                        }

                    }
                    connection.Close();
                }

                return carPartsList;
            }
            catch (Exception)
            {
                return carPartsList;
            }
        }

        public List<CarDetailsModel> SearchCarInSystem(int status, string searchKey)
        {
            List<CarDetailsModel> carList = new List<CarDetailsModel>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = command.CommandText = @"SELECT C.*, M.Name AS ModelName, MN.Name AS ManufacturerName FROM Cars C INNER JOIN Models M on C.ModelId = M.Id INNER JOIN Manufacturers MN ON C.ManufacturerId = MN.Id WHERE M.Name LIKE '%' + @key + '%' AND C.Status = @status AND C.IsActive = 1";

                        command.Parameters.Add("@Key", SqlDbType.VarChar).Value = searchKey;
                        command.Parameters.Add("@Status", SqlDbType.Int).Value = status;

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
            catch (Exception)
            {
                return carList;
            }
        }
    }
}
