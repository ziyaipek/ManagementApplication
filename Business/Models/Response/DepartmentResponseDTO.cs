using System;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response
{
    public class DepartmentResponseDTO
    {
        public string Name { get; set; } = default!;
    }
}
