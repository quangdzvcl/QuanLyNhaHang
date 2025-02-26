using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public OrderController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<Order> Get()
        {
            return _dbContext.Order;
        }
    }
}
