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

        public List<CarOrderModel> GetAllCarOrders(int status)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarOrders(status);
        }

        public List<CarPartOrderModel> GetAllCarPartOrders(int status)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetAllCarPartOrders(status);
        }
    }
}
