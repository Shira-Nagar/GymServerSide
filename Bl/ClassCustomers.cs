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
        public static void PostCustomer(Dto.ClassSubscription c)
        {
            Dal.ClassCustomers.PostCustomer(Dto.Convert.CustomersConvert.PostCusOne(c));
        }

    }
}
