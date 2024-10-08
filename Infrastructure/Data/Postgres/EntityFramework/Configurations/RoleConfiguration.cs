using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class RoleConfiguration : BaseConfiguration<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            // Data seed for Role
            var data = new Role[]
            {
                new Role { Id = 1, Name = "Admin", IsAdmin = true, CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false },
                new Role { Id = 2, Name = "Employee", IsAdmin = false, CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false }
            };

            builder.HasData(data);
        }
    }
}
