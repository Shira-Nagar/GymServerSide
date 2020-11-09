using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class ClassFitnessLesson
    {
        public static List<FitnessLessons> GetAllFitLe()
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    return g.FitnessLessons.ToList();
                }


            }
            catch (Exception e)
            {
                return null;
            }
        }
            public static FitnessLessons GetFitnesslesson(int id)
            {
                try
                {
                    using (GymDBEntities g = new GymDBEntities())
                    {
                        foreach (var item in g.FitnessLessons)
                        {
                            if (item.lesson_id == id)
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
            public static void PostFitnessLesson(FitnessLessons f)
            {
                try
                {
                    using (GymDBEntities g = new GymDBEntities())
                    {
                        g.FitnessLessons.Add(f);
                        g.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            public static void DeleteFitnessLesson(int id)
            {
                try
                {
                    using (GymDBEntities g = new GymDBEntities())
                    {
                        g.FitnessLessons.Remove(g.FitnessLessons.Where(a => a.lesson_id == id).First());
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

