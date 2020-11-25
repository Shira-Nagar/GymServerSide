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
                    Training_id = item.training_id,
                    name = item.name,
                    description = item.description,
                    quota = item.quota
                };
                   
                DtoTrainings.Add(t);
            }
            return DtoTrainings;
        }

        

        public static ClassTraining GetDtoTraining(Dal.Training Training)
        {
            ClassTraining t = new ClassTraining()
            {
                Training_id = Training.training_id,
                name = Training.name,
                description = Training.description,
                quota = Training.quota
            };
            return t;
        }
        public static Dal.Training PostTraining(ClassTraining Training)
        {
            Dal.Training t = new Dal.Training()
            {
                training_id = Training.Training_id,
                name = Training.name,
                description = Training.description,
                quota = Training.quota
            };

            return t;
        }
    }
}

