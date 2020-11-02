using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
   
    
    public class ClosedGroupesController : ApiController
    {


        // GET: api/ClosedGroupes
        public List<Dto.ClassClosedGroups> Get()
        {
            return Bl.ClassClosedGroups.GetAllClosedGroupes();
        }

        // GET: api/ClosedGroupes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ClosedGroupes
        public void Post(Dto.ClassClosedGroups c)
        {
            Bl.ClassClosedGroups.PostClosedGroups(c);
        }

        // PUT: api/ClosedGroupes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClosedGroupes/5
        public void Delete(int id)
        {
            Bl.ClassClosedGroups.DeleteClosedGroups(id);
        }
    }
}
