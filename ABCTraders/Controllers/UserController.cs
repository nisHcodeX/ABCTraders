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
    internal class UserController
    {
        public AdminModel AdminSignIn(string email, string password)
        {
            var adminRepository = new AdminRepository();
            var admin = adminRepository.getAdminByEmail(email);

            if(admin != null)
            {
                if(admin.Password == password)
                {
                    return admin;
                }else { return admin; }
            }else { return admin; }
        }

        public bool CustomerRegister(CustomerDto dto)
        {
            dto.Email.ToLower().Trim();
            var customerRepository = new CustomerRepository();
            var customerRegistered = customerRepository.CreateCustomer(dto);

            if(customerRegistered > 0)
            {
                return true;
            }
            return false;
        }
        public bool IsEmailExist(string email)
        {
            var customerRepository = new CustomerRepository();
            var customer = customerRepository.GetCustomerByEmail(email);
            if (customer != null)
            {
                return true;
            }
            return false;
        }
    }
}
