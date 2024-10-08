using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres;


public class EmployeeService : BaseService<Employee, int, EmployeeResponseDTO>, IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapperHelper _mapperHelper;

    public EmployeeService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
        : base(unitOfWork, unitOfWork.Employees, mapperHelper)
    {
        _unitOfWork = unitOfWork;
        _mapperHelper = mapperHelper;
    }

    public async Task<EmployeeResponseDTO> AddEmployeeAsync(Employee employee)
    {
        // Email adresinin var olup olmadığını kontrol et
        var existingEmployee = await _unitOfWork.Employees
            .AnyAsync(e => e.Email == employee.Email);

        if (existingEmployee)
        {
            throw new Exception("Bu email adresi zaten kullanımda.");
        }

        // Yeni çalışanı ekle
        await _unitOfWork.Employees.AddAsync(employee);
        await _unitOfWork.CommitAsync();

        return _mapperHelper.Map<EmployeeResponseDTO>(employee);
    }

}
