using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClassCustomers
    {
        public static List<Customers> GetAllCustomers()
        {
            try
            {
                using (GymEntities g = new GymEntities())
                    return g.Customers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostCustomer(Customers c)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    g.Customers.Add(c);
                    g.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
