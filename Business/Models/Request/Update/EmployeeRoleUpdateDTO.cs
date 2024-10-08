using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class EmployeeRoleUpdateDTO
    {
        public Employee Employee { get; set; } = default!;
        public int RoleId { get; set; }
        public Role Role { get; set; } = default!;
    }
}
