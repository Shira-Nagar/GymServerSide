using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bl
{
   public class ClassFitnessLesson
    {
        public static List<Dto.ClassFitnessLesson> GetAllFitnessLessons()
        {
            return Dto.Convert.FitnessLessonConvert.GetAllFitnessLessons(Dal.ClassFitnessLesson.GetAllFitLe());
        }
        public static Dto.ClassFitnessLesson GetFitnessLesson(int id)
        {
            return Dto.Convert.FitnessLessonConvert.GetDtoFitLeOne(Dal.ClassFitnessLesson.GetFitnesslesson(id));   
        }
        public static void PostFitnessLessons(Dto.ClassFitnessLesson f)
        {
            Dal.ClassFitnessLesson.PostFitnessLesson(Dto.Convert.FitnessLessonConvert.PostFitLeOne(f));
        }
        public static void DeleteFitnessLessons(int id)
        {
            Dal.ClassFitnessLesson.DeleteFitnessLesson(id);
        }
            
    }
}



