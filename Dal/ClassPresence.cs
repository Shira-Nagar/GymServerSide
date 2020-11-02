using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClassPresence
    {
       
            public static List<Presence> GetAllPresence()
            {
                try
                {
                    using (GymEntities g = new GymEntities())
                    {
                        return g.Presence.ToList();
                    }
                }
                catch (Exception e)
                {
                    return null;
                }

            }
            

            public static void PostPresence(Presence p)
            {
                try
                {
                    using (GymEntities g = new GymEntities())
                    {
                        g.Presence.Add(p);
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
