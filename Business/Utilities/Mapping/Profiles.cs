using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping
{
    public class Profiles : AutoMapper.Profile
    {
        public Profiles()
        {
            // Create Mappings
            CreateMap<DepartmentCreateDTO, Department>();
            CreateMap<EmployeeCreateDTO, Employee>();
            CreateMap<RoleCreateDTO, Role>();
            CreateMap<EmployeeRoleCreateDTO, EmployeeRole>();

            // Update Mappings
            CreateMap<DepartmentUpdateDTO, Department>();
            CreateMap<EmployeeUpdateDTO, Employee>();
            CreateMap<RoleUpdateDTO, Role>();
            CreateMap<EmployeeRoleUpdateDTO, EmployeeRole>();

            // Response Mappings
            // Doğru haritalama: Department -> DepartmentResponseDTO
            CreateMap<Department, DepartmentResponseDTO>(); // Bu satırı ekledik
            CreateMap<Employee, EmployeeResponseDTO>();
            CreateMap<Role, RoleResponseDTO>();
            CreateMap<EmployeeRole, EmployeeRoleResponseDTO>();
        }
    }
}
