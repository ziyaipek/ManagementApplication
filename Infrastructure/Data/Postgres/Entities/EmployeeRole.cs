using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class EmployeeRole : Entity<int>
    {
        // Foreign Key for Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = default!;

        // Foreign Key for Role
        public int RoleId { get; set; }
        public Role Role { get; set; } = default!;
    }
}
