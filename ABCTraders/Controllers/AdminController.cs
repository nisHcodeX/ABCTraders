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

        public List<AddCarModel> GetAllCars()
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllCars();
        }

        public List<AddCarPartModel> GetAllCarParts()
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllCarParts();
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
    }
}
