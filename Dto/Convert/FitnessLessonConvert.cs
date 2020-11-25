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
                    lesson_id = item.lesson_id,
                    name = item.name,
                    day = item.day,
                    time = item.time,
                    trainer_id = item.trainer_id,
                    gender = item.gender,
                    actual_capacity = item.actual_capacity,
                    status = item.status,
                };

                DtoFitnesslesson.Add(f);
            }
            return DtoFitnesslesson;
        }
            public static ClassFitnessLesson GetDtoFitLeOne(Dal.FitnessLessons fitle)
            {
                ClassFitnessLesson f = new ClassFitnessLesson()
                {
                    lesson_id = fitle.lesson_id,
                    name = fitle.name,
                    day = fitle.day,
                    time = fitle.time,
                    trainer_id = fitle.trainer_id,
                    gender = fitle.gender,
                    actual_capacity = fitle.actual_capacity,
                    status = fitle.status,
                };

                return f;
            }
            public static Dal.FitnessLessons PostFitLeOne(ClassFitnessLesson fitle)
            {
                Dal.FitnessLessons f = new Dal.FitnessLessons()
                {
                    lesson_id = fitle.lesson_id,
                    name = fitle.name,
                    day = fitle.day,
                    time = fitle.time,
                    trainer_id = fitle.trainer_id,
                    gender = fitle.gender,
                    actual_capacity = fitle.actual_capacity,
                    status = fitle.status,
                };

                return f;
            }
        }
    }
