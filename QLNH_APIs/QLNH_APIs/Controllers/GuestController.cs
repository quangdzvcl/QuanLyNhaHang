using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GuestController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public GuestController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<Guest> Get()
        {
            return _dbContext.Guest;
        }
    }
}
