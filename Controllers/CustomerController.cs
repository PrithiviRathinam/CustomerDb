using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MongoDBEFCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly MongDbService service;

        public CustomerController(MongDbService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustomerDTO customer)
        {           
            service.AddCustomer(customer);
            return Ok();
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return service.GetCustomers();
        }

    }
}
