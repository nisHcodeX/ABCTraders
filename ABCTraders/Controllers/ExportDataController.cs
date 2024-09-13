using ABCTraders.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Controllers
{
    internal class ExportDataController
    {
        [Obsolete]
        public bool ExportCars()
        {
            var carController = new AdminController();
            var cars = carController.GetAllCars();

            if (cars == null) return false;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Model Name");
            dataTable.Columns.Add("Manufacture Name");
            dataTable.Columns.Add("VIN");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Fuel Type");
            dataTable.Columns.Add("Condition");

            var loader = new CommonLoader();
            foreach (var car in cars)
            {
                var status = loader.GetStatus((int)car.Status);
                var condition = loader.GetConditionName((int)car.Condition);
                var fuelType = loader.GetFuelType((int)car.FuelType);
                dataTable.Rows.Add(new object[] { car.Id, car.ModelName, car.ManufacturerName, car.VIN, car.Price.ToString(), car.Description, status, car.Year, fuelType, condition });
            }

            var utility = new Utility();
            var filename = $"cars_data_{DateTime.Today.ToString("yyyy-MMM-dd")}.pdf";
            return utility.WriteToPdfFile(dataTable, $"C:\\Users\\LENOVO\\Downloads\\{filename}");
        }

        [Obsolete]
        public bool ExportCarParts()
        {
            var carController = new AdminController();
            var parts = carController.GetAllCarParts();

            if (parts == null) return false;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Part Code");
            dataTable.Columns.Add("Part Name");
            dataTable.Columns.Add("Manufacturer Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Condtion");


            var loader = new CommonLoader();
            foreach (var part in parts)
            {
                var condition = loader.GetConditionName((int)part.Condition);
                dataTable.Rows.Add(new object[] { part.Id, part.PartCode, part.PartName, part.ManufacturerName, part.StockQuantity.ToString(), part.Price.ToString(), part.Description, condition });
            }

            var utility = new Utility();
            var filename = $"car_parts_data_{DateTime.Today.ToString("yyyy-MMM-dd")}.pdf";
            return utility.WriteToPdfFile(dataTable, $"C:\\Users\\LENOVO\\Downloads\\{filename}");
        }

        [Obsolete]
        public bool ExportCustomers()
        {
            var customerController = new UserController();
            var customers = customerController.GetAllCustomers();
            var orderController = new OrderController();

            if (customers == null) return false;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Contact");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Car Orders");
            dataTable.Columns.Add("Car Part Order");

            foreach (var customer in customers)
            {
                dataTable.Rows.Add(new object[] { customer.Id, customer.FirstName, customer.Email, customer.Email, customer.Address, orderController.GetAllCarOrdersByCustomer(customer.Id).Count.ToString(), orderController.GetAllCarPartOrdersByCustomer(customer.Id).Count.ToString() });
            }

            var utility = new Utility();
            var filename = $"customers_data_{DateTime.Today.ToString("yyyy-MMM-dd")}.pdf";
            return utility.WriteToPdfFile(dataTable, $"C:\\Users\\LENOVO\\Downloads\\{filename}");
        }

        [Obsolete]
        public bool ExportCarOrders()
        {
            var orderController = new OrderController();
            var carOrders = orderController.GetAllCarOrders();

            if (carOrders == null) return false;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Car Name");
            dataTable.Columns.Add("Car VIN");
            dataTable.Columns.Add("Manufacture Name");
            dataTable.Columns.Add("Customer Id");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Ordered Date");
            dataTable.Columns.Add("Approved Date");
            dataTable.Columns.Add("DeliveredDate Date");


            var loader = new CommonLoader();
            foreach (var carOrder in carOrders)
            {
                dataTable.Rows.Add(new object[] { carOrder.Id, carOrder.ModelName, carOrder.VIN, carOrder.ManufacturerName, carOrder.CustomerId, carOrder.FristName, carOrder.Description, carOrder.Price.ToString(), carOrder.OrderedDate, carOrder.ApprovedDate, carOrder.DeliveredDate });
            }

            var utility = new Utility();
            var filename = $"car_orders_data_{DateTime.Today.ToString("yyyy-MMM-dd")}.pdf";
            return utility.WriteToPdfFile(dataTable, $"C:\\Users\\LENOVO\\Downloads\\{filename}");
        }

        [Obsolete]
        public bool ExportCarPartOrders()
        {
            var orderController = new OrderController();
            var carPartOrders = orderController.GetAllCarPartOrders();

            if (carPartOrders == null) return false;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Part Name");
            dataTable.Columns.Add("Customer Id");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Ordered Date");
            dataTable.Columns.Add("Approved Date");
            dataTable.Columns.Add("DeliveredDate Date");


            var loader = new CommonLoader();
            foreach (var partOrder in carPartOrders)
            {
                dataTable.Rows.Add(new object[] { partOrder.Id, partOrder.PartName, partOrder.CustomerId, partOrder.FristName, partOrder.Description, partOrder.Quantity.ToString(), partOrder.Price.ToString(), partOrder.OrderedDate, partOrder.ApprovedDate, partOrder.DeliveredDate });
            }

            var utility = new Utility();
            var filename = $"car_parts_order_data_{DateTime.Today.ToString("yyyy-MMM-dd")}.pdf";
            return utility.WriteToPdfFile(dataTable, $"C:\\Users\\LENOVO\\Downloads\\{filename}");
        }
    }
}
