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
        public List<ClassSubscriptionsTypes> Get()
        {
            return Bl.ClassSubsciptionsTypes.GetAllSubscriptions();
        }

        // GET: api/S/5
        public ClassSubscriptionsTypes  Get(int id)
        {
            return Bl.ClassSubsciptionsTypes.GetSubscription(id);
        }

        // POST: api/S
        public void Post(Dto.ClassSubscriptionsTypes s)
        {
            Bl.ClassSubsciptionsTypes.PostSubscription(s);
        }
      
        // PUT: api/S/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/S/5
        public void Delete(int id)
        {
            Bl.ClassSubsciptionsTypes.DeleteSubscription(id);
        }

    }
}
