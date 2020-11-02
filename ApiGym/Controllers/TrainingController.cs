using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymApi.Controllers
{
    public class TrainingController : ApiController
    {
        // GET: api/Training
        public List<ClassTraining> Get()
        {
            return Bl.ClassTraining.GetAllTraining();
        }

        // GET: api/Training/5
        public ClassTraining Get(int id)
        {
            return Bl.ClassTraining.GetTraining(id);
        }

        // POST: api/Training
        public void PostTraining(Dto.ClassTraining t)
        {
            Bl.ClassTraining.PostTraining(t);
        }

        // PUT: api/Training/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Training/5
        public void Delete(int id)
        {
            Bl.ClassTraining.DeleteTraining(id);
        }
    }
}
