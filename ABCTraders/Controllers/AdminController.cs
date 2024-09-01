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
            var addCarSucces = adminRepository.UpdateCarToSystem(id, dto);

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

        public List<CarDetailsModel> GetAllCars(int status)
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllCars(status);
        }

        public List<AddCarPartModel> GetAllCarParts(int status)
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
    }
}
