using System.Data;
using System.Linq.Expressions;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class EmployeeRepository : Repository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<bool> AnyAsync(Expression<Func<Employee, bool>> predicate)
        {
            return await PostgresContext.Set<Employee>().AnyAsync(predicate);
        }
    }
}
