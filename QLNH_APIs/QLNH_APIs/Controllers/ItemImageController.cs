using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ItemImageController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public ItemImageController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet()]
        public IEnumerable<ItemImage> Get()
        {
            return _dbContext.ItemImage;
        }
    }
}
