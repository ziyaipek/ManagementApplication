using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;

namespace Business.Services
{
    public class DepartmentService : BaseService<Department, int, DepartmentResponseDTO>, IDepartmentService
    {
        public DepartmentService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.Departments, mapperHelper)
        {
        }
    }
}
