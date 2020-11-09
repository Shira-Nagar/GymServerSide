using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;

namespace GymApi.Controllers
{
    public class PresenceController : ApiController
    {
        // GET: api/Presence
         public List<Dto.ClassPresence> Get()
        {
            return Bl.ClassPresence.GetAllPresences();
        }

        // GET: api/Presence/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Presence
        public void Post(Dto.ClassPresence P)
        {
             Bl.ClassPresence.PostPresence(P);
        }

        // PUT: api/Presence/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Presence/5
        public void Delete(int id)
        {
        }

       
    }
}
