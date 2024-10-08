using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class EmployeeConfiguration : BaseConfiguration<Employee, int>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.HasIndex(e => e.Email).IsUnique();
            builder.HasIndex(e => e.Phone).IsUnique();

            // Data seed for Employee
            var data = new Employee[]
            {
                new Employee { Id = 1, FullName = "Ali Veli", Email = "ali@example.com", Phone = "1234567890", DepartmentId = 1, CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false },
                new Employee { Id = 2, FullName = "Ayşe Kaya", Email = "ayse@example.com", Phone = "0987654321", DepartmentId = 2, CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false }
            };

            builder.HasData(data);

            builder.HasOne(e => e.Department)
                .WithMany()
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
