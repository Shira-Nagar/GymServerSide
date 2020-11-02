using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
  public  class ClassFitnessTrainers
    {
        public static List<Dto.ClassFitnessTrainers> GetAllFitnessTrainers(List<Dal.FitnessTrainers> ft)
        {
            return Dto.Convert.FitnessTrainersConvert.GetAllFitnessTrainers(Dal.ClassFitnessTrainers.GetAllFitnessTrainers());
        }
  

        public static ClassFitnessTrainers GetFitnessTrainer(int id)
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


   