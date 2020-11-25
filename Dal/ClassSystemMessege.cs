using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Dal
{
     public class ClassSystemMessege
    {
        public static List<SystemMessege> GetAllMesseges()
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    return g.SystemMessege.OrderByDescending(x => x.Creation_date).ToList();
                    
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public static SystemMessege GetMessege(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    foreach (var item in g.SystemMessege)
                    {
                        if (item.Messege_id == id)
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
        public static void PostSMessege(SystemMessege sm)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.SystemMessege.Add(sm);
                    g.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void DeleteSMessege(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.SystemMessege.Remove(g.SystemMessege.Where(a => a.Messege_id == id).First());
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
