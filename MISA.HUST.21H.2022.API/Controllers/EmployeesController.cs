using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.HUST._21H._2022.API.Entities;
using MISA.HUST._21H._2022.API.Entities.DTO;
using MISA.HUST._21H._2022.API.Enums;

namespace MISA.HUST._21H._2022.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// API lấy tất cả danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách tất cả nhân viên</returns>
        /// Created by: NVDIA(1/9/2022)
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return StatusCode(StatusCodes.Status200OK, new List<Employee>
            {
                new Employee
                {
                    EmployeeID=Guid.NewGuid(),
                    EmployeeCode="NV11111",
                    EmployeeName="Nguyễn Văn Dìa",
                    DateOfBirth=DateTime.Now,
                    Gender=Gender.Male,
                    IdentityNumber="123456789102",
                    IdentityIssuedPlace="CA Hà Nội",
                    IdentityIssuedDate=DateTime.Now,
                    Email="nguyenvandiat@gmail.com",
                    PhoneNumber="123456789",
                    PositionID=Guid.NewGuid(),
                    PositionName="Kế toán",
                    DepartmentID=Guid.NewGuid(),
                    DepartmentName="Phòng kế toán",
                    TaxCode="123456789",
                    Salary=12345678,
                    JoiningDate=DateTime.Now,
                    WorkStatus=WorkStatus.CurrentlyWorking,
                    CreatedDate=DateTime.Now,
                    CreatedBy="Nguyễn hữu nhân",
                    ModifiedDate=DateTime.Now,
                    ModifiedBy="Nguyễn hữu nhân"
                },
                 new Employee
                {
                    EmployeeID=Guid.NewGuid(),
                    EmployeeCode="NV11112",
                    EmployeeName="Nguyễn Hữu Nhân",
                    DateOfBirth=DateTime.Now,
                    Gender=Gender.Male,
                    IdentityNumber="123456789103",
                    IdentityIssuedPlace="CA Hà Nội",
                    IdentityIssuedDate=DateTime.Now,
                    Email="nguyenhuunhant@gmail.com",
                    PhoneNumber="123456789",
                    PositionID=Guid.NewGuid(),
                    PositionName="Kế toán",
                    DepartmentID=Guid.NewGuid(),
                    DepartmentName="Phòng kế toán",
                    TaxCode="123456789",
                    Salary=12345678,
                    JoiningDate=DateTime.Now,
                    WorkStatus=WorkStatus.CurrentlyWorking,
                    CreatedDate=DateTime.Now,
                    CreatedBy="Nguyễn văn dìa",
                    ModifiedDate=DateTime.Now,
                    ModifiedBy="Nguyễn Văn dìa"
                }
            });
        }
        /// <summary>
        /// API lấy thông tin chi tiết nhân viên
        /// </summary>
        /// <param name="employeeID">ID nhân viên</param>
        /// <returns>Thông tin chi tiết một nhân viên</returns>
        /// Created by: NVDIA(1/9/2022)
        [HttpGet]
        [Route("{employeeID}")]
        public IActionResult GetEmployeeByID([FromRoute] Guid employeeID)
        {
            return StatusCode(StatusCodes.Status200OK, new Employee
            {
                EmployeeID = Guid.NewGuid(),
                EmployeeCode = "NV11111",
                EmployeeName = "Nguyễn Văn Dìa",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                IdentityNumber = "123456789102",
                IdentityIssuedPlace = "CA Hà Nội",
                IdentityIssuedDate = DateTime.Now,
                Email = "nguyenvandiat@gmail.com",
                PhoneNumber = "123456789",
                PositionID = Guid.NewGuid(),
                PositionName = "Kế toán",
                DepartmentID = Guid.NewGuid(),
                DepartmentName = "Phòng kế toán",
                TaxCode = "123456789",
                Salary = 12345678,
                JoiningDate = DateTime.Now,
                WorkStatus = WorkStatus.CurrentlyWorking,
                CreatedDate = DateTime.Now,
                CreatedBy = "Nguyễn hữu nhân",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Nguyễn hữu nhân"
            });
        }
        /// <summary>
        /// API lọc danh sách nhân viên có điều kiện tìm và phân trang
        /// </summary>
        /// <param name="keyword">Từ khóa muốn tìm kiếm (Mã nhân viên, tên nhân viên, số điện thoại )</param>
        /// <param name="positionID">ID vị trí</param>
        /// <param name="departmentID">ID phòng ban</param>
        /// <param name="pageSize">Số bảng ghi trên một trang</param>
        /// <param name="pageNumber">Vị trí bảng ghi bát đầu lấy dữ liệu</param>
        /// <returns>Danh sách nhân viên</returns>
        /// Created by: NVDIA (1/9/2022)
        [HttpGet]
        [Route("filter")]
        public IActionResult FilterEmployees(
            [FromQuery] string? keyword,
            [FromQuery] Guid? positionID,
            [FromQuery] Guid? departmentID,
            [FromQuery] int pageSize = 10,
            [FromQuery] int pageNumber = 1
            )
        {
            return StatusCode(StatusCodes.Status200OK, new PagingData<Employee>
            {
                Data = new List<Employee>
                {
                         new Employee
                        {
                            EmployeeID=Guid.NewGuid(),
                            EmployeeCode="NV11111",
                            EmployeeName="Nguyễn Văn Dìa",
                            DateOfBirth=DateTime.Now,
                            Gender=Gender.Male,
                            IdentityNumber="123456789102",
                            IdentityIssuedPlace="CA Hà Nội",
                            IdentityIssuedDate=DateTime.Now,
                            Email="nguyenvandiat@gmail.com",
                            PhoneNumber="123456789",
                            PositionID=Guid.NewGuid(),
                            PositionName="Kế toán",
                            DepartmentID=Guid.NewGuid(),
                            DepartmentName="Phòng kế toán",
                            TaxCode="123456789",
                            Salary=12345678,
                            JoiningDate=DateTime.Now,
                            WorkStatus=WorkStatus.CurrentlyWorking,
                            CreatedDate=DateTime.Now,
                            CreatedBy="Nguyễn hữu nhân",
                            ModifiedDate=DateTime.Now,
                            ModifiedBy="Nguyễn hữu nhân"
                        },
                         new Employee
                        {
                            EmployeeID=Guid.NewGuid(),
                            EmployeeCode="NV11112",
                            EmployeeName="Nguyễn Hữu Nhân",
                            DateOfBirth=DateTime.Now,
                            Gender=Gender.Male,
                            IdentityNumber="123456789103",
                            IdentityIssuedPlace="CA Hà Nội",
                            IdentityIssuedDate=DateTime.Now,
                            Email="nguyenhuunhant@gmail.com",
                            PhoneNumber="123456789",
                            PositionID=Guid.NewGuid(),
                            PositionName="Kế toán",
                            DepartmentID=Guid.NewGuid(),
                            DepartmentName="Phòng kế toán",
                            TaxCode="123456789",
                            Salary=12345678,
                            JoiningDate=DateTime.Now,
                            WorkStatus=WorkStatus.CurrentlyWorking,
                            CreatedDate=DateTime.Now,
                            CreatedBy="Nguyễn văn dìa",
                            ModifiedDate=DateTime.Now,
                            ModifiedBy="Nguyễn Văn dìa"
                        }

                },
                TotalCount = 2
            });
        }
        /// <summary>
        /// API thêm mới một nhân viên
        /// </summary>
        /// <param name="employee">Đối tượng nhân viên cần thêm mới</param>
        /// <returns>ID nhân viên vừa thêm mới</returns>
        /// Create by: NVDIA (1/9/2022)
        [HttpPost]
        public IActionResult InsertEmployee([FromBody] Employee employee)
        {
            return StatusCode(StatusCodes.Status201Created,Guid.NewGuid());
        }
        /// <summary>
        /// API sửa một nhân viên
        /// </summary>
        /// <param name="employee">Đối tượng nhân viên cần sửa</param>
        /// <param name="employeeID">ID nhân viên muốn sửa</param>
        /// <returns>ID nhân viên cần sửa</returns>
        /// Create by: NVDIA (1/9/2022)
        [HttpPut]
        [Route("{employeeID}")]
        public IActionResult UpdateEmployee([FromBody] Employee employee, [FromRoute] Guid employeeID)
        {
            return StatusCode(StatusCodes.Status201Created,employeeID);
        }
        /// <summary>
        /// API xóa nhân viên
        /// </summary>
        /// <param name="employeeID">ID của nhân viên muốn xóa</param>
        /// <returns>ID nhân viên cần sửa</returns>
        /// Create by: NVDIA (1/9/2022)
        [HttpDelete]
        [Route("{employeeID}")]
        public IActionResult DeleteEmployee([FromRoute] Guid employeeID)
        {
            return StatusCode(StatusCodes.Status201Created, employeeID);
        }
    }
}
