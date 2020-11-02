using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class ClassTraining
    {
        public static List<Dto.ClassTraining> GetAllTraining()
        {
            return Dto.Convert.TrainingConvert.GetDtoTrainings(Dal.ClassTraining.GetAllTraining());
        }
        public static ClassTraining GetTraining(int id)
        {
            return Dto.Convert.TrainingConvert.GetDtoTraining(Dal.ClassTraining.GetTraining(id));
        }
        public static void PostTraining(Dto.ClassTraining t)
        {
            Dal.ClassTraining.PostTrain(Dto.Convert.TrainingConvert.PostTraining(t));
        }
        public static void DeleteTraining(int id)
        {
            Dal.ClassTraining.DeleteTraining(id);
        }
    }
}