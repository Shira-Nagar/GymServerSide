
using Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;

namespace GymApi.Controllers
{
    public class FitnessTrainersController : ApiController
    {
        // GET: api/FitnessTrainer
        public List<Dto.ClassFitnessTrainers> Get()
        {
            return Bl.ClassFitnessTrainers.GetAllFitnessTrainers();

        }

        // GET: api/FitnessTrainer/5
        public Dto.ClassFitnessTrainers Get(int id)
        {
            return Bl.ClassFitnessTrainers.GetFitnessTrainer(id);
        }

        // POST: api/FitnessTrainer
        public void Post(Dto.ClassFitnessTrainers ft)
        {
            Bl.ClassFitnessTrainers.PostFitnessTrainer(ft);
        }

        // PUT: api/FitnessTrainer/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/FitnessTrainer/5
        public void Delete(int id)
        {
            Bl.ClassFitnessTrainers.DeleteFitnessTrainer(id);
        }
    }
}
