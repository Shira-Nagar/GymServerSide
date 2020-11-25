using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl;
using Dto;


namespace ApiGym.Controllers
{
    [RoutePrefix("api/Purchases")]
    public class PurchasesController : ApiController
    {        
        [HttpGet]
        [Route("GetAllPurchases")]
        // GET: api/Purchaces
        public List<Dto.ClassPurchases> Get()
        {
            return Bl.ClassPurchases.GetAllPurchases();
        }

        [HttpGet]
        [Route("GetSinglePurchases")]
        // GET: api/Purchaces/5
        public Dto.ClassPurchases Get(int id)
        {
            return Bl.ClassPurchases.GetSinglePurchase(id);
        }

        [HttpGet]
        [Route("GetListOfCustomersByTrainingId/{training_id}")]
        public List<Dto.ClassPurchases> GetCustomersByTrainingId(int training_id)
        {
            return Bl.ClassPurchases.GetListOfTrainers(training_id);
        }


        // POST: api/Purchaces
        public void Post(Dto.ClassPurchases p)
        {
            Bl.ClassPurchases.PostPurchases(p);
        }

        // PUT: api/Purchaces/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Purchaces/5
        public void Delete(int id)
        {
            Bl.ClassPurchases.DeletePurchase(id);
        }
    }
}
