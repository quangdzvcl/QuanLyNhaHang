using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;
using System.Linq.Expressions;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitTypeController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public UnitTypeController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<UnitType> Get()
        {
            return _dbContext.UnitType;
        }
    }
}
