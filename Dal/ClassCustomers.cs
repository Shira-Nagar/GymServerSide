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
        public static List<Purchases> GetPurchasesByPassword(string user_name,string password)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    Customers cc = g.Customers.First(a => a.user_name == user_name && a.id_number == password);
                    int customerId = cc.customer_id;
                    List<Purchases> p = new List<Purchases>();
                    p = g.Purchases.Where(pp => pp.customer_id == customerId).ToList();
                    return p;
                }
                    
            }
            catch
            {
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
