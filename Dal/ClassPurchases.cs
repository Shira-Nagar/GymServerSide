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
                using (GymDBEntities g = new GymDBEntities())
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
                using (GymDBEntities g = new GymDBEntities())
                {
                    //אם קוד הלקוח זהה תצרף אותו לרשימה
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


        public static List<Purchases> GetListOfCustomers(int training_id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    List<Purchases> l = new List<Purchases>();

                    foreach (var item in g.Purchases)
                    {
                        //אם קוד השיעור זהה תכניס את הלקוח לרשימה
                        if (item.sub_id == training_id)
                            l.Add(item);
                    }
                    return l;
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
                using (GymDBEntities g = new GymDBEntities())
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
                using(GymDBEntities g = new GymDBEntities())
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
