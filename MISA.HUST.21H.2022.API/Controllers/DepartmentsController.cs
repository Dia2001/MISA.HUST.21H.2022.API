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
    public class DepartmentsController : ControllerBase
    {
        private string connectionString = AppSettings.Instance.ConnectionString;
        /// <summary>
        /// API lấy danh sách tất cả phòng ban
        /// </summary>
        /// <returns>Danh sách tất cả phòng ban</returns>
        /// Created by: NVDIA(1/9/2022)
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            try
            {
                // Khởi tạo kết nối tới DB MySQL
                var mySqlConnection = new MySqlConnection(connectionString);

                // Chuẩn bị câu lệnh truy vấn
                string getAllDepartmentsCommand = "SELECT * FROM department;";

                // Thực hiện gọi vào DB để chạy câu lệnh truy vấn ở trên
                var departments = mySqlConnection.Query<Department>(getAllDepartmentsCommand);

                // Xử lý dữ liệu trả về
                if (departments != null)
                {
                    // Trả về dữ liệu cho client
                    return StatusCode(StatusCodes.Status200OK, departments);
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
