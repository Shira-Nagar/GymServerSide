using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl
{
    public class ClassCustomers
    {
        public static List<Dto.ClassCustomers> GetAllCustomers()
        {            
            return Dto.Convert.CustomersConvert.GetDtoCust(Dal.ClassCustomers.GetAllCustomers());
        }

        public static Dto.ClassCustomers GetCustomerById(int id)
        {
            return Dto.Convert.CustomersConvert.GetCusOne(Dal.ClassCustomers.GetOneCustomer(id));
        }

        public static void PostCustomer(Dto.ClassCustomers c)
        {
            Dal.ClassCustomers.PostCustomer(Dto.Convert.CustomersConvert.PostCusOne(c));
        }

    }
}
