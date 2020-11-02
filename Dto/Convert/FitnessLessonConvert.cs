using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Convert
{
   public class FitnessLessonConvert
    {
        public static List<ClassFitnessLesson> GetAllFitnessLessons(List<Dal.FitnessLessons> allf)
        {
            List<ClassFitnessLesson> DtoFitnesslesson = new List<ClassFitnessLesson>();
            foreach (var item in allf)
            {
                ClassFitnessLesson f = new ClassFitnessLesson()
                {
                    name = item.name,
                    trainer_id = item.trainer_id,
                    lesson_id = item.lesson_id,
                    day = item.day,
                    time = item.time,
                    quota_training = item.quota_training,
                };

                DtoFitnesslesson.Add(f);
            }
            return DtoFitnesslesson;
        }
            public static ClassFitnessLesson GetDtoFitLeOne(Dal.FitnessLessons fitle)
            {
                ClassFitnessLesson f = new ClassFitnessLesson()
                {
                    name = fitle.name,
                    trainer_id = fitle.trainer_id,
                    lesson_id = fitle.lesson_id,
                    day = fitle.day,
                    time = fitle.time,
                    quota_training = fitle.quota_training,
                };

                return f;
            }
            public static Dal.FitnessLessons PostFitLeOne(ClassFitnessLesson fitle)
            {
                Dal.FitnessLessons f = new Dal.FitnessLessons()
                {
                   
                    name = fitle.name,
                    trainer_id = fitle.trainer_id,
                    lesson_id = fitle.lesson_id,
                    day = fitle.day,
                    time = fitle.time,
                    quota_training = fitle.quota_training,
                };

                return f;
            }
        }
    }
