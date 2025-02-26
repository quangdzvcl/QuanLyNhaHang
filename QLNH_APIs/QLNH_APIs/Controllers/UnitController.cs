using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;
using System.Linq.Expressions;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public UnitController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<Unit> Get()
        {
            return _dbContext.Unit;
        }
    }
}
