using System;
using System.Collections.Generic;
using Dto;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymApi.Controllers
{
    public class FitnessLessonController : ApiController
    {
        // GET: api/FitnessLesson
        public List<Dto.ClassFitnessLesson> Get()
        {
            return Bl.ClassFitnessLesson.GetAllFitnessLessons();
        }

        // GET: api/FitnessLesson/5
        public Dto.ClassFitnessLesson Get(int id)
        {
            return Bl.ClassFitnessLesson.GetFitnessLesson(id);
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
            Bl.ClassFitnessLesson.DeleteFitnessLessons(id);
        }
    }
}
