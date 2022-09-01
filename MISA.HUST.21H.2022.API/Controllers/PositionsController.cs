using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.HUST._21H._2022.API.Entities;

namespace MISA.HUST._21H._2022.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        /// <summary>
        /// API lấy danh sách tất cả vị trí
        /// </summary>
        /// <returns>Danh sách tất cả vị trí</returns>
        /// Created by: NVDIA(1/9/2022)
        [HttpGet]
        public IActionResult GetAllPositions()
        {
            return StatusCode(StatusCodes.Status200OK, new List<Position>
            {
               new Position
               {
                   PositionID=Guid.NewGuid(),
                   PositionCode="P1111",
                   PositionName="Chủ tịch",
                   CreatedDate=DateTime.Now,
                   CreatedBy="Nguyễn Hữu Nhân",
                   ModifiedDate=DateTime.Now,
                   ModifiedBy="Nguyễn Hữu Nhân"
               }
            });
        }
    }
}
