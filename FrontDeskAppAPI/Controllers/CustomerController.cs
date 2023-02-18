using FrontDeskAppAPI.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontDeskAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet(Name = "GetCustomerList")]
        public async Task<IActionResult> Get()
        {
            var customers = await new APIDbContext().Customers.ToListAsync();
            return Ok(customers);
        }
    }
}
