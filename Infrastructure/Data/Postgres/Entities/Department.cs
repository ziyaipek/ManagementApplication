using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Department : Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
