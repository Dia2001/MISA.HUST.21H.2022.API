using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.HUST._21H._2022.API.Entities;
using MISA.HUST._21H._2022.API.Helper;
using MySqlConnector;

namespace MISA.HUST._21H._2022.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private string connectionString = AppSettings.Instance.ConnectionString;

        /// <summary>
        /// API lấy danh sách tất cả vị trí
        /// </summary>
        /// <returns>Danh sách tất cả vị trí</returns>
        /// Created by: NVDIA(1/9/2022)
        [HttpGet]
        public IActionResult GetAllPositions()
        {
            try
            {
                // Khởi tạo kết nối tới DB MySQL
                var mySqlConnection = new MySqlConnection(connectionString);

                // Chuẩn bị câu lệnh truy vấn
                string getAllPositionsCommand = "SELECT * FROM positions;";

                // Thực hiện gọi vào DB để chạy câu lệnh truy vấn ở trên
                var positions = mySqlConnection.Query<Position>(getAllPositionsCommand);

                // Xử lý dữ liệu trả về
                if (positions != null)
                {
                    // Trả về dữ liệu cho client
                    return StatusCode(StatusCodes.Status200OK, positions);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "e002");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return StatusCode(StatusCodes.Status400BadRequest, "e001");
            }
        }
    }
}
