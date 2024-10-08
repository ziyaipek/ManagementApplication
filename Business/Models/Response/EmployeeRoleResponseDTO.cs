using System;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response
{
    public class EmployeeRoleResponseDTO
    {
        public Employee Employee { get; set; } = default!;
        public int RoleId { get; set; }
        public Role Role { get; set; } = default!;
    }
}
