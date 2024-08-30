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
                        command.CommandText = "SELECT * FROM Customer WHERE Email = @Email AND IsActive = 1";
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            customer = new CustomerModel
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                Email = reader["Email"].ToString(),
                                Password = reader["Password"].ToString(),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                LastLoginDate = reader["LastLoginDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["LastLoginDate"]) : (DateTime?)null,
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
                        command.CommandText = @"INSERT INTO Customer(FirstName, LastName, Email, Address, Contact, Password, IsActive, UserType,  CreatedDate, LastLoginDate)
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
    }
}
