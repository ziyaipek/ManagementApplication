using System.Data;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class EmployeeRoleRepository : Repository<EmployeeRole, int>, IEmployeeRoleRepository
    {
        public EmployeeRoleRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
    }
}
