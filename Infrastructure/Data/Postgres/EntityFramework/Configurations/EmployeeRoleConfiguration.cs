using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmployeeRoleConfiguration : BaseConfiguration<EmployeeRole, int>
{
    public override void Configure(EntityTypeBuilder<EmployeeRole> builder)
    {
        base.Configure(builder);

        // Anahtar tanımlama
        builder.HasKey(er => new { er.EmployeeId, er.RoleId });

        // İlişki tanımlamaları
        builder.HasOne(er => er.Employee)
            .WithMany(e => e.EmployeeRoles)
            .HasForeignKey(er => er.EmployeeId);

        builder.HasOne(er => er.Role)
            .WithMany(r => r.EmployeeRoles)
            .HasForeignKey(er => er.RoleId);

        var data = new EmployeeRole[]
        {
            new EmployeeRole { Id = 1, RoleId = 1, EmployeeId = 1 },
            new EmployeeRole { Id = 2, RoleId = 2, EmployeeId = 1 },
            // Diğer seed verilerini buraya ekleyin
        };

        builder.HasData(data);
    }
}
