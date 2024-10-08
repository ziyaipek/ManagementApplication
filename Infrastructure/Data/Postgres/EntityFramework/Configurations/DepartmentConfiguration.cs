using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DepartmentConfiguration : BaseConfiguration<Department, int>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);

            // Data seed for Department
            var data = new Department[]
            {
                new Department { Id = 1, Name = "IT", CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false },
                new Department { Id = 2, Name = "HR", CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false }
            };

            builder.HasData(data);
        }
    }
}
