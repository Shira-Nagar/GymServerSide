using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public   class ClassClosedGroups
    {
        public static List<ClosedGroupes> GetAllClosedGroups()
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    return g.ClosedGroupes.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public static ClosedGroupes GetClosedGroups(int id)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    foreach (var item in g.ClosedGroupes)
                    {
                        if (item.team_id == id)
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
        public static void PostClosedGroups(ClosedGroupes Cg)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    g.ClosedGroupes.Add(Cg);
                    g.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void DeleteClosedGroups(int id)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    g.ClosedGroupes.Remove(g.ClosedGroupes.Where(a => a.team_id == id).First());
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
