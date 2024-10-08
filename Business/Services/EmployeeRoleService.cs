using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;

namespace Business.Services
{
    public class EmployeeRoleService : BaseService<EmployeeRole, int, EmployeeRoleResponseDTO>, IEmployeeRoleService
    {
        public EmployeeRoleService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.EmployeeRoles, mapperHelper)
        {
        }
    }
}
