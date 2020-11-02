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
            return Bl.ClassSystemMessege.GetOneMessege(Dto.Convert.SystemMessegeConvert.GetDtoSMessege(id));
        }

        // POST: api/SystemMessege
        public void Post(List<Bl.ClassSystemMessege> ms)
        {
            Dal.ClassSystemMessege.PostSMessege(Dto.Convert.SystemMessegeConvert.PostSMessege(ms));
        }

        // PUT: api/SystemMessege/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SystemMessege/5
        public void Delete(int id)
        {
            Dal.ClassSystemMessege.DeleteSMessege(id);
        }
    }
}
