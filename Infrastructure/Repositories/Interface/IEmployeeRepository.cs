using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
        Task<bool> AnyAsync(Expression<Func<Employee, bool>> predicate);

    }
}
