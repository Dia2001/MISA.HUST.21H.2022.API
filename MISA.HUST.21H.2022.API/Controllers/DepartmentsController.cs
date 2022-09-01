using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.HUST._21H._2022.API.Entities;

namespace MISA.HUST._21H._2022.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        /// <summary>
        /// API lấy danh sách tất cả phòng ban
        /// </summary>
        /// <returns>Danh sách tất cả phòng ban</returns>
        /// Created by: NVDIA(1/9/2022)
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            return StatusCode(StatusCodes.Status200OK, new List<Department>
            {
               new Department
               {
                   DepartmentID=Guid.NewGuid(),
                   DepartmentCode="D1111",
                   DepartmentName="Phòng chủ tịch",
                   CreatedDate=DateTime.Now,
                   CreatedBy="Nguyễn Hữu Nhân",
                   ModifiedDate=DateTime.Now,
                   ModifiedBy="Nguyễn Hữu Nhân"
               }
            });
        }
    }
}
