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

namespace ABCTraders.Repository
{
    internal class OrderRepository: DbConnection
    {
        public int AddCarOrderToSystem(CarOrderDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO CarOrders(CarId, CustomerId, Price, Status, OrderedDate)
                        VALUES(@CarId, @CustomerId, @Price, @Status, GETDATE())";

                        command.Parameters.Add("@CarId", SqlDbType.NVarChar).Value = dto.CarId;
                        command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = dto.CustomerId;
                        command.Parameters.Add("@Status", SqlDbType.Int).Value = dto.Status;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.Price;
                        command.Parameters.Add("@IsActive ", SqlDbType.Bit).Value = 1;

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

        public int AddCarPartOrderToSystem(PartOrderDto dto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO CarPartOrders(PartId, CustomerId, Quantity, FullPrice, Status, OrderedDate)
                        VALUES(@PartId, @CustomerId, @Quantity, @FullPrice, @Status, GETDATE())";

                        command.Parameters.Add("@PartId", SqlDbType.NVarChar).Value = dto.PartId;
                        command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = dto.CustomerId;
                        command.Parameters.Add("@Quantity", SqlDbType.Int).Value = dto.Quantity;
                        command.Parameters.Add("@FullPrice", SqlDbType.Decimal).Value = dto.FullPrice;
                        command.Parameters.Add("@Status", SqlDbType.Int).Value = dto.Status;
                        command.Parameters.Add("@IsActive ", SqlDbType.Bit).Value = 1;

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

        public List<CarOrderModel> GetAllCarOrders(int status)
        {
            try
            {
                var carList = new List<CarOrderModel>();

                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.CommandText = @"SELECT CO.*,C.Id, C.Id as CustomerId, C.FirstName,C.Email, M.Name AS ModelName, MN.Name as ManufactureName, CR.VIN, CR.Description, CR.Condition From CarOrders CO 
                        INNER JOIN Customers C ON CO.CustomerId = C.ID INNER JOIN Cars CR ON CO.CarId = CR.Id 
                        INNER JOIN Models M on CR.ModelId = M.Id 
                        INNER JOIN Manufacturers MN on M.ManufacturerId = MN.Id Where CO.IsActive = 1 AND CO.Status = @status";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new CarOrderModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                CustomerId = Convert.ToInt32(reader["CustomerId"].ToString()),
                                VIN = reader["VIN"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"].ToString()),
                                ModelName = reader["ModelName"].ToString(),
                                ManufacturerName = reader["ManufactureName"].ToString(),
                                FristName = reader["FirstName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Status = Convert.ToInt32(reader["Status"]),
                                Description = reader["Description"].ToString(),
                                Conditon = Convert.ToInt32(reader["Condition"]),
                                ApprovedDate = reader["ApprovedDate"] != DBNull.Value ? Convert.ToDateTime(reader["ApprovedDate"]).ToString() : null,
                                OrderedDate = reader["OrderedDate"] != DBNull.Value ? Convert.ToDateTime(reader["OrderedDate"]).ToString() : null,
                                DeliveredDate = reader["DeliveredDate"] != DBNull.Value ? Convert.ToDateTime(reader["DeliveredDate"]).ToString() : null,
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

        public List<CarPartOrderModel> GetAllCarPartOrders(int status)
        {
            try
            {
                var partList = new List<CarPartOrderModel>();

                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.CommandText = @"SELECT CO.*, C.Email, C.Id as CustomerId, C.FirstName, CP.Condition, CP.PartName, CP.Category, CP.Description FROM CarPartOrders CO INNER JOIN Customers C ON CO.CustomerId = C.ID INNER JOIN CarParts CP ON CO.PartId = CP.ID Where CO.IsActive = 1 AND CO.Status=@status";

                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var carPart = new CarPartOrderModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                CustomerId = Convert.ToInt32(reader["CustomerId"].ToString()),
                                PartName = Convert.ToString(reader["PartName"].ToString()),
                                Price = Convert.ToDecimal(reader["FullPrice"].ToString()),
                                Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
                                FristName = reader["FirstName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Status = Convert.ToInt32(reader["Status"]),
                                Description = reader["Description"].ToString(),
                                Conditon = Convert.ToInt32(reader["Condition"]),
                                ApprovedDate = reader["ApprovedDate"] != DBNull.Value ? Convert.ToDateTime(reader["ApprovedDate"]).ToString() : null,
                                OrderedDate = reader["OrderedDate"] != DBNull.Value ? Convert.ToDateTime(reader["OrderedDate"]).ToString() : null,
                                DeliveredDate = reader["DeliveredDate"] != DBNull.Value ? Convert.ToDateTime(reader["DeliveredDate"]).ToString() : null,
                            };
                            partList.Add(carPart);
                        }
                    }
                    connection.Close();
                }
                return partList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
