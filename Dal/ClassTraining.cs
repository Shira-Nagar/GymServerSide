using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
     public class ClassTraining
    {
        public static List<Training> GetAllTraining()
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    return g.Training.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public static Training GetTraining(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    foreach (var item in g.Training)
                    {
                        if (item.training_id == id)
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
        public static void PostTrain(Training t)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.Training.Add(t);
                    g.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void DeleteTraining(int id)
        {
            try
            {
                using (GymDBEntities g = new GymDBEntities())
                {
                    g.Training.Remove(g.Training.Where(a => a.training_id == id).First());
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
