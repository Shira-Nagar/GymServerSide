using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClassSubscriptionsTypes
    {
       public static  List<SubscriptionsTypes> GetAllSubscription()
        {
            try
            {
                using (GymDBEntities g=new GymDBEntities())
                {
                    return g.SubscriptionsTypes.ToList();
                }
            }
            catch(Exception e)
            {
                return null;
            }
        
        }
        public static SubscriptionsTypes GetSubscription(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    foreach (var item in g.SubscriptionsTypes)
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
        public static void PostSubscription(SubscriptionsTypes s)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.SubscriptionsTypes.Add(s);
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
                    g.SubscriptionsTypes.Remove(g.SubscriptionsTypes.Where(a => a.sub_id == id).First());
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
