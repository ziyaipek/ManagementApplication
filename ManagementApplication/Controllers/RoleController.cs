using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class RoleController : BaseCRUDController<Role, int, RoleCreateDTO, RoleUpdateDTO, RoleResponseDTO>
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService) : base(roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public async Task<IActionResult> AddRole([FromBody] RoleCreateDTO roleCreateDTO)
        {
            if (roleCreateDTO == null)
            {
                return BadRequest("Rol bilgisi eksik.");
            }

            var role = new Role
            {
                Name = roleCreateDTO.Name,
                IsAdmin = roleCreateDTO.IsAdmin
            };

            var result = await _roleService.AddRoleAsync(role);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return CreatedAtAction(nameof(GetById), new { id = role.Id }, role);
        }
    }
}
