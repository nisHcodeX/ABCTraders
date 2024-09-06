using ABCTraders.Dto;
using ABCTraders.Model;
using ABCTraders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            if (admin != null)
            {
                var isPasswordValid = ComparePasswords(password, admin.Password);
                if (!isPasswordValid)
                {
                    return null;
                }
                return admin;
            }
            return null;
        }

        public bool CustomerRegister(CustomerDto dto)
        {
            dto.Email.ToLower().Trim();
            dto.Password = Encrypt(dto.Password);

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

        public CustomerModel SignIn(string email, string password)
        {
            var customerRepository = new CustomerRepository();

            var customer = customerRepository.GetCustomerByEmail(email);

            if (customer != null)
            {
                var isPasswordValid = ComparePasswords(password, customer.Password);

                if (!isPasswordValid)
                {
                    return null;
                }

                return customer;
            }

            return null;
        }

        public bool UpdateCustomer(int Id, CustomerModel dto)
        {
            var customerRepository = new CustomerRepository();
            var customerUpdated = customerRepository.UpdateCustomer(Id, dto);
            if (customerUpdated > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CustomerModel> GetAllCustomers()
        {
            var customerRepository = new CustomerRepository();
            return customerRepository.GetAllCustomers();
        }

        public List<AddCarPartDetailModel> SearchCarPart(int status, string searchKey)
        {
            var customerRepository = new CustomerRepository();

            var result = customerRepository.SearchCarPartInSystem(status, searchKey);
            return result;
        }
        
        public List<CarDetailsModel> SearchCar(int status, string searchKey)
        {
            var customerRepository = new CustomerRepository();

            var result = customerRepository.SearchCarInSystem(status, searchKey);
            return result;
        }

        public int UpdatePassword(int id, string password)
        {
            var customerRepository = new CustomerRepository();
            var hash = Encrypt(password);
            var result = customerRepository.UpdateCustomerPassword(id, hash);
            return result;
        }

        public bool ComparePasswords(string password, string encryptedPassword)
        {
            var hash = Encrypt(password);

            if (hash == encryptedPassword)
            {
                return true;
            }

            return false;
        }

        private string Encrypt(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                var hash = md5.ComputeHash(new UTF8Encoding().GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }

    }
}
