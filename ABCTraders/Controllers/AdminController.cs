using ABCTraders.Dto;
using ABCTraders.Model;
using ABCTraders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABCTraders.Controllers
{
    internal class AdminController
    {
        public bool AddCar(AddCarDto dto)
        {
            
            var adminRepository = new AdminRepository();
            var addCarSucces = adminRepository.AddCarToSystem(dto);

            if (addCarSucces > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCar(int id, AddCarDto dto)
        {

            var adminRepository = new AdminRepository();
            var updateCarSuccess = adminRepository.UpdateCarToSystem(id, dto);

            if (updateCarSuccess > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddCarPart(AddCarPartDto dto)
        {

            var adminRepository = new AdminRepository();
            var addCarSucces = adminRepository.AddCarPartToSystem(dto);

            if (addCarSucces > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCarPart(int id, AddCarPartDto dto)
        {

            var adminRepository = new AdminRepository();
            var addPartSuccess = adminRepository.UpdateCarPartToSystem(id, dto);

            if (addPartSuccess > 0)
            {
                return true;
            }
            return false;
        }

        public List<CarDetailsModel> GetAllCars(int status)
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllCars(status);
        }

        public List<AddCarPartDetailModel> GetAllCarParts(int status)
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllCarParts(status);
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllManufacturers();
        }

        public List<CarModel> GetAllModels(int id)
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllModels(id);
        }

        public int DeleteCar(int carId)
        {
            var adminRepository = new AdminRepository();
            var result = adminRepository.DeleteCarById(carId);
            return result;
        }

        public int DeleteCarPart(int partId)
        {
            var adminRepository = new AdminRepository();

            var result = adminRepository.DeleteCarPartById(partId);
            return result;
        }

        public bool UpdateCarStatus(int Id, int status)
        {
            var adminRepository = new AdminRepository();

            var carStatusUpdated = adminRepository.UpdateCarStatus( Id, status);
            if (carStatusUpdated > 0)
            {
                return true;
            }
            return false;
        }
        
        public bool UpdateCarPartStatus( int Id, int status)
        {
            var adminRepository = new AdminRepository();

            var partStatusUpdated = adminRepository.UpdateCarPartStatus(Id, status);

            if (partStatusUpdated > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCarPartStock(int Id, int stock)
        {
            var adminRepository = new AdminRepository();

            var partStatusUpdated = adminRepository.UpdateCarPartStock(Id, stock);

            if (partStatusUpdated > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCustomer(int Id, CustomerDto dto)
        {
            var adminRepository = new AdminRepository();
            var customerUpdated = adminRepository.UpdateCustomerByAdmin(Id, dto);
            if (customerUpdated > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
