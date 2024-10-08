using Business.Models.Response;
using Business.Services.Base.Interface;
using Core.Results;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services.Interface;

public interface IRoleService : IBaseService<Role, int, RoleResponseDTO>
{
    Task<Result> AddRoleAsync(Role role);
}