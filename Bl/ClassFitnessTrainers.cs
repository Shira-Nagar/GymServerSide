using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;


namespace Bl
{
  public  class ClassFitnessTrainers
    {
        public static List<Dto.ClassFitnessTrainers> GetAllFitnessTrainers()
        {
            return Dto.Convert.FitnessTrainersConvert.GetAllFitnessTrainers(Dal.ClassFitnessTrainers.GetAllFitnessTrainers());
        }
 
        public static Dto.ClassFitnessTrainers GetFitnessTrainer(int id)
        {
           return Dto.Convert.FitnessTrainersConvert.GetDtoFitnessTrainer(Dal.ClassFitnessTrainers.GetFitnessTrainers(id));
        }

        public static void PostFitnessTrainer(Dto.ClassFitnessTrainers ft)
        {
            Dal.ClassFitnessTrainers.PostFitnessTrainer(Dto.Convert.FitnessTrainersConvert.PostFitnessTrainer(ft));
        }

        public static void DeleteFitnessTrainer(int id)
        {
            Dal.ClassFitnessTrainers.DeleteFitnessTrainer(id);
        }
  }   
}


   