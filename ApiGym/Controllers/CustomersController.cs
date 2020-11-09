using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace GymApi.Controllers
{
    //[RoutePrefix("api/Customers")]
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public List<Dto.ClassCustomers> Get()
        {
            return Bl.ClassCustomers.GetAllCustomers();
        }

        //    // GET: api/Customers/5
        //[HttpGet]
        //[Route("GetCustomerById/{id}")]
        public Dto.ClassCustomers Get(int id)
        {
            return Bl.ClassCustomers.GetCustomerById(id);
        }

        //    // POST: api/Customers
        public void PostCustomer(Dto.ClassCustomers c)
        {
            Bl.ClassCustomers.PostCustomer(c);
        }

       // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

       // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
}
}
