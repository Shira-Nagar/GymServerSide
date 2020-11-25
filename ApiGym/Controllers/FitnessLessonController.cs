using System;
using System.Collections.Generic;
using Dto;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymApi.Controllers
{
    [RoutePrefix("api/FitnessLesson")]
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
        //מציאת שיעורים לפי יום
        [HttpGet]
        [Route("GetLessonsByDay")]
        public List<Dto.ClassFitnessLesson> GetLessonsByDay(string day)
        {
            return Bl.ClassFitnessLesson.GetLessonsByDay(day);
        }
        //מציאת שיעורים לפי שעה
        [HttpGet]
        [Route("GetLessonsByTime")]
        public List<Dto.ClassFitnessLesson> GetLessonsByTime(TimeSpan time)
        {
            return Bl.ClassFitnessLesson.GetLessonsByTime(time);
        }

        //מציאת שיעורים לפי סוג החוג
        [HttpGet]
        [Route("GetLessonsByType")]
        public List<Dto.ClassFitnessLesson> GetLessonsByType(int name)
        {
            return Bl.ClassFitnessLesson.GetLessonsByType(name);
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
