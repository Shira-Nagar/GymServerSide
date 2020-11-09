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
                using (GymDBEntities g = new GymDBEntities())
                    return g.Customers.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static Customers GetOneCustomer(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                    foreach (var item in g.Customers)
                    {
                        if (item.customer_id == id)
                            return item;
                    }
                return null;
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
                using (GymDBEntities g = new GymDBEntities())
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

        public static void DeleteCustomer(int id)
        {
            try
            {
                using(GymDBEntities g = new GymDBEntities())
                {
                    g.Customers.Remove(g.Customers.Where(x => x.customer_id == id).First());
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
