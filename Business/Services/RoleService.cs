using System;
using System.Threading.Tasks;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Microsoft.AspNetCore.Http;
using Core.Results;

namespace Business.Services
{
    public class RoleService : BaseService<Role, int, RoleResponseDTO>, IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RoleService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper, IHttpContextAccessor httpContextAccessor)
            : base(unitOfWork, unitOfWork.Roles, mapperHelper)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Result> AddRoleAsync(Role role)
        {
            var user = _httpContextAccessor.HttpContext.User;
           
            if (role.IsAdmin)
            {
                if (!user.IsInRole("Admin"))
                {
                    return Result.Failure("Yönetici olmayanlar admin rolü ekleyemez.");
                }
            }

            // Normal ekleme işlemi
            await _unitOfWork.Roles.AddAsync(role);
            await _unitOfWork.CommitAsync();

            return Result.Success();
        }
    }
}
