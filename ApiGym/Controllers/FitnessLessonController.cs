using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymApi.Controllers
{
    public class FitnessLessonController : ApiController
    {
        // GET: api/FitnessLesson
        public List<ClassFitnessLesson> Get()
        {
            return Bl.ClassFitnessLesson.GetAllFitnessLessons();
        }

        // GET: api/FitnessLesson/5
        public ClassFitnessLesson Get(int id)
        {
            return Bl.ClassFitnessTrainers.GetFitnessTrainer(Dto.Convert.FitnessTrainersConvert.GetDtoFitnessTrainer(id));
        }

        // POST: api/FitnessLesson
        public void Post(Dto.ClassFitnessLesson Fl)
        {
            Bl.ClassFitnessLesson.PostFitnessLessons(Fl);
        }

        // PUT: api/FitnessLesson/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FitnessLesson/5
        public void Delete(int id)
        {
            Dal.ClassFitnessLesson.DeleteFitnessLesson(id);
        }
    }
}
