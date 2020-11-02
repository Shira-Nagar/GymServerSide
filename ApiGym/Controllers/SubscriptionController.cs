using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
namespace GymApi.Controllers
{
    public class SubscriptionController : ApiController
    {
        // GET: api/S
        public List<ClassSubscription> Get()
        {
            return Bl.ClassSubsciption.GetAllSubscriptions();
        }

        // GET: api/S/5
        public ClassSubscription  Get(int id)
        {
            return Bl.ClassSubsciption.GetSubscription(id);
        }

        // POST: api/S
        public void Post(Dto.ClassSubscription s)
        {
            Bl.ClassSubsciption.PostSubscription(s);
        }
      
        // PUT: api/S/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/S/5
        public void Delete(int id)
        {
            Bl.ClassSubsciption.DeleteSubscription(id);
        }

    }
}
