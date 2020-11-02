using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClassFitnessTrainers
    {
        public static List<FitnessTrainers> GetAllFitnessTrainers()
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    return g.FitnessTrainers.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static FitnessTrainers GetFitnessTrainers(int id)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    foreach (var item in g.FitnessTrainers)
                    {
                        if (item.guide_id == id)
                        {
                            return item;
                        }
                        return null;
                    }
                }

            }
            catch(Exception e)
            {
                return null;
            }
            return null;
        }
        public static void PostFitnessTrainer(FitnessTrainers ft)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    g.FitnessTrainers.Add(ft);
                    g.SaveChanges();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void DeleteFitnessTrainer(int id)
        {
            try
            {
                using (GymEntities g = new GymEntities())
                {
                    g.FitnessTrainers.Remove(g.FitnessTrainers.Where(a => a.guide_id == id).First());
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