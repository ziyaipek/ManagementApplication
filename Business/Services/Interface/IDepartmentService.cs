using Business.Models.Response;
using Business.Services.Base.Interface;
using Core.Results;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services.Interface;

public interface IDepartmentService : IBaseService<Department, int, DepartmentResponseDTO>
{


}