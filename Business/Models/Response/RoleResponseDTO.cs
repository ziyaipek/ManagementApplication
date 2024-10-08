using System;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response
{
    public class RoleResponseDTO
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; }
    }
}
