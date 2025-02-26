using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public StatusController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<Status> Get()
        {
            return _dbContext.Status;
        }
    }
}
