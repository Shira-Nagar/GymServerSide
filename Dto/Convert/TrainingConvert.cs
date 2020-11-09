using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Convert
{
   public class TrainingConvert
    {
        public static List<ClassTraining> GetDtoTrainings(List<Dal.Training> allt)
        {
            List<ClassTraining> DtoTrainings = new List<ClassTraining>();
            foreach (var item in allt)
            {
                ClassTraining t = new ClassTraining()
                {
                    name = item.name,
                    descripition = item.description,
                    Training_id = item.training_id
                };
                   
                DtoTrainings.Add(t);
            }
            return DtoTrainings;
        }

        

        public static ClassTraining GetDtoTraining(Dal.Training Training)
        {
            ClassTraining t = new ClassTraining()
            {
                name = Training.name,
                descripition = Training.description,
                Training_id = Training.training_id,
            };
            return t;
        }
        public static Dal.Training PostTraining(ClassTraining Training)
        {
            Dal.Training t = new Dal.Training()
            {
                name = Training.name,
                description=Training.descripition,
                training_id = Training.Training_id,
            };

            return t;
        }
    }
}

