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
    internal class CarPartController
    {
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

        public List<AddCarPartDetailModel> GetAllCarParts()
        {
            var adminRepository = new AdminRepository();
            return adminRepository.GetAllCarParts();
        }


    }
}
