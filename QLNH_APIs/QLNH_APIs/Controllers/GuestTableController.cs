using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GuestTableController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public GuestTableController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<GuestTable> Get()
        {
            return _dbContext.GuestTable;
        }
    }
}
