using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClassPurchases
    {
        public static List<Purchases> GetAllPurchases()
        {
            try
            {
                using (GymEntities g = new GymEntities())
                    return g.Purchases.ToList();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static Purchases GetPurchasesById(int id)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    foreach(var item in g.Purchases)
                    {
                        if (item.customer_id == id)
                            return item;
                    }
                    return null;
                }
                
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostPurchase(Purchases p)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    g.Purchases.Add(p);
                    g.SaveChanges();

                }
                    

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
    
        }

        public static void DeletePurchase(int id)
        {
            try
            {
                using(GymEntities g = new GymEntities())
                {
                    g.Purchases.Remove(g.Purchases.Where(x => x.customer_id == id).First());
                    g.SaveChanges();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
