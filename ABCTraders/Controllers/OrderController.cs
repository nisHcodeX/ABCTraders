using ABCTraders.Dto;
using ABCTraders.Model;
using ABCTraders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Controllers
{
    internal class OrderController
    {
        public bool CarOrder(CarOrderDto dto)
        {

            var orderRepository = new OrderRepository();
            var carOrderSucces = orderRepository.AddCarOrderToSystem(dto);

            if (carOrderSucces > 0)
            {
                return true;
            }
            return false;
        }
        public bool CarPartOrder(PartOrderDto dto)
        {
            var orderRepository = new OrderRepository();
            var addCarSucces =  orderRepository.AddCarPartOrderToSystem(dto);

            if (addCarSucces > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCarOrderByAdmin(int id, int status)
        {

            var orderRepository = new OrderRepository();
            var carOrder = orderRepository.UpdateCarOrderByAdmin(id, status);

            if (carOrder > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCarOrder(int id, int status)
        {

            var orderRepository = new OrderRepository();
            var carOrder = orderRepository.UpdateCarOrder(id, status);

            if (carOrder > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCarPartOrder(int id, int status)
        {

            var orderRepository = new OrderRepository();
            var carOrder = orderRepository.UpdateCarPartOrder(id, status);

            if (carOrder > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCarPartOrderByAdmin(int id, int status)
        {

            var orderRepository = new OrderRepository();
            var carOrder = orderRepository.UpdateCarPartOrderByAdmin(id, status);

            if (carOrder > 0)
            {
                return true;
            }
            return false;
        }
        public List<CarOrderModel> GetAllCarOrdersByStatus(int status)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarOrdersByStatus(status);
        }

        public List<CarOrderModel> GetAllCarOrders()
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarOrders();
        }

        public List<CarPartOrderModel> GetAllCarPartOrdersByStaus(int status)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarPartOrdersByStatus(status);
        }
        public List<CarPartOrderModel> GetAllCarPartOrders()
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarPartOrders();
        }

        public List<CarOrderModel> GetAllCarOrdersByCustomer(int customerId)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarOrdersByCustomer(customerId);
        }

        public List<CarPartOrderModel> GetAllCarPartOrdersByCustomer(int customerId)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarPartOrdersByCustomer(customerId);
        }
    }
}
