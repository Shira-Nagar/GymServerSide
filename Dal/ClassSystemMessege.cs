using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Dal
{
     public class ClassSystemMessege
    {
        public static List<SystemMesseges> GetAllMesseges()
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    return g.SystemMesseges.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public static SystemMesseges GetMessege(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    foreach (var item in g.SystemMesseges)
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
        public static void PostSMessege(SystemMesseges sm)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.SystemMesseges.Add(sm);
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
                    g.SystemMesseges.Remove(g.SystemMesseges.Where(a => a.Messege_id == id).First());
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
