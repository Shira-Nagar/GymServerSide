
using Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymApi.Controllers
{
    public class FitnessTrainersController : ApiController
    {
        // GET: api/FitnessTrainer
        public List<ClassFitnessTrainers> Get()
        {
            return Bl.ClassFitnessTrainers.GetAllFitnessTrainers(Dto.Convert.FitnessTrainersConvert.GetAllFitnessTrainers());

        }

        // GET: api/FitnessTrainer/5
        public ClassFitnessTrainers Get(int id)
        {
            return Bl.ClassFitnessTrainers.GetFitnessTrainer(id);
        }

        // POST: api/FitnessTrainer
        public void Post(Dto.ClassFitnessTrainers ft)
        {
            Dal.ClassFitnessTrainers.PostFitnessTrainer(Dto.Convert.FitnessTrainersConvert.PostFitnessTrainer(ft));
        }

        // PUT: api/FitnessTrainer/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/FitnessTrainer/5
        public void Delete(int id)
        {
            Dal.ClassFitnessTrainers.DeleteFitnessTrainer(id);
        }
    }
}
