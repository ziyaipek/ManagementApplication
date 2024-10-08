using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;


namespace Web.Controllers
{
    public class EmployeeController : BaseCRUDController<Employee, int, EmployeeCreateDTO, EmployeeUpdateDTO, EmployeeResponseDTO>
    {
        public EmployeeController(IEmployeeService service) : base(service)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeCreateDTO employeeCreateDTO)
        {
            if (employeeCreateDTO == null)
            {
                return BadRequest("Çalışan bilgileri eksik.");
            }

            var employee = new Employee
            {
                FullName = employeeCreateDTO.FullName,
                Email = employeeCreateDTO.Email,
                Phone = employeeCreateDTO.Phone,
                DepartmentId = employeeCreateDTO.DepartmentId
            };

            try
            {
                var employeeResponse = await (_service as IEmployeeService).AddEmployeeAsync(employee); 
                return CreatedAtAction(nameof(GetById), new { id = employeeResponse.Id }, employeeResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
