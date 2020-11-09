using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymApi.Controllers
{
    public class SystemMessegeController : ApiController
    {
        // GET: api/SystemMessege
        public List<Dto.ClassSystemMessege> Get()
        {
            return Bl.ClassSystemMessege.GetAllMesseges();
        }

        // GET: api/SystemMessege/5
        public Dto.ClassSystemMessege Get(int id)
        {
            return Bl.ClassSystemMessege.GetOneMessege(id);
        }

        // POST: api/SystemMessege
        public void Post(Dto.ClassSystemMessege ms)
        {
            Bl.ClassSystemMessege.PostSMesseges(ms);
        }

        // PUT: api/SystemMessege/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SystemMessege/5
        public void Delete(int id)
        {
            Bl.ClassSystemMessege.DeleteSMessege(id);
        }
    }
}
