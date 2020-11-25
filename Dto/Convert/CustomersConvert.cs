using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto.Convert
{
    public class CustomersConvert
    {
        public static List<ClassCustomers> GetDtoCust(List<Customers> allC)
        {
            List<ClassCustomers> DtoCu = new List<ClassCustomers>();
            foreach (var item in allC)
            {
                ClassCustomers c = new ClassCustomers()
                {
                    customer_id = item.customer_id,
                    name = item.name,
                    id_number = item.id_number,
                    email = item.email,
                    phone_num = item.phone,
                    user_name = item.user_name
                };
                DtoCu.Add(c);
            }
            return DtoCu;
        }

        public static ClassCustomers GetCusOne(Customers c)
        {
            ClassCustomers cl = new ClassCustomers()
            {
                customer_id = c.customer_id,
                name = c.name,
                id_number = c.id_number,
                email = c.email,
                phone_num = c.phone,
                user_name = c.user_name
            };
            return cl;
        }

        public static Customers PostCusOne(ClassCustomers Cus)
        {
            Dal.Customers c = new Dal.Customers()
            {
                customer_id = Cus.customer_id,
                name = Cus.name,
                id_number = Cus.id_number,
                email = Cus.email,
                phone = Cus.phone_num,
                user_name = Cus.user_name
            };

            return c;
        }

        
    }
}

