using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public RoleController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Lấy danh sách tất cả các role
        /// </summary>
        /// <returns> Danh sách role</returns>
        [HttpGet()]
        public IEnumerable<Role> Get()
        {
            return _dbContext.Role;
        }

        /// <summary>
        /// Lấy role theo ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Trả về role tương ứng với id</returns>
        [HttpGet("Id")]
        public Role Get([FromQuery] int Id)
        {
            return _dbContext.Role.FirstOrDefault(x => x.Id == Id);
            // return _dbContext.Role.Where(x=>x.Id ==Id).FirstOrDefault();
        }

        /// <summary>
        /// Thêm role mới
        /// </summary>
        /// <param name="role"></param>
        /// <returns>Role</returns>
        [HttpPost]
        public Role Post([FromQuery] Role role)
        {
            _dbContext.Role.Add(role);
            _dbContext.SaveChanges();
            return role;
        }
    }
}
