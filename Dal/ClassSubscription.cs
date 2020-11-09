using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClassSubscription
    {
       public static  List<Subscriptions> GetAllSubscription()
        {
            try
            {
                using (GymDBEntities g=new GymDBEntities())
                {
                    return g.Subscriptions.ToList();
                }
            }
            catch(Exception e)
            {
                return null;
            }
        
        }
        public static Subscriptions GetSubscription(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    foreach (var item in g.Subscriptions)
                    {
                        if(item.sub_id==id)
                        {
                            return item;
                        }
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static void PostSubscription(Subscriptions s)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.Subscriptions.Add(s);
                    g.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void DeleteSubscription(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.Subscriptions.Remove(g.Subscriptions.Where(a => a.sub_id == id).First());
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
