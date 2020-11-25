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
                    using (GymDBEntities g = new GymDBEntities())
                    {
                    return null;/*g.Presence.GroupBy(p => p.lesson_id).OrderBy(o => o.Key).Select(s => s.Key);*/

                    //g.Presence.GroupBy(p => p.sub_id,
                    //                              p => p.lesson_id,
                    //                              (key, gr) => new { sub_id = key, lesson_id = gr.ToList() });


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
                    using (GymDBEntities g = new GymDBEntities())
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
