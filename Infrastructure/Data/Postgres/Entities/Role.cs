using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Role : Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; }

        public ICollection<EmployeeRole> EmployeeRoles { get; set; } = new List<EmployeeRole>();

    }
}
