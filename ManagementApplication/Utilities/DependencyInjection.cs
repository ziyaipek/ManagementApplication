using Business.Services;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Infrastructure.Data.Postgres.Repositories;

namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDepartmentService, DepartmentService>();
        serviceCollection.AddScoped<IEmployeeService, EmployeeService>();
        serviceCollection.AddScoped<IRoleService, RoleService>();
        serviceCollection.AddScoped<IEmployeeRoleService, EmployeeRoleService>();

        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddScoped<IUserContext, UserContext>();
        serviceCollection.AddScoped<IDepartmentRepository, DepartmentRepository>();
        serviceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
        serviceCollection.AddScoped<IRoleRepository, RoleRepository>();
        serviceCollection.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();
    }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        // Uncomment below lines if you have those services implemented
        //serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        //serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        //serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
    }

    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
    }
}
