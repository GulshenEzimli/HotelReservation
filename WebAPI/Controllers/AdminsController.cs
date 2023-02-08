using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private IAdminService _adminService;

        public AdminsController(IAdminService adminService)
        {
            this._adminService = adminService;
        }

        [HttpPost("add")]
        public IActionResult Add(Admin admin)
        {
            var result = this._adminService.Add(admin);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(Admin admin)
        {
            var result = this._adminService.Update(admin);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Admin admin)
        {
            var result = this._adminService.Delete(admin);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Admin, bool>>? filter)
        {
            var result = this._adminService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Admin, bool>> filter)
        {
            var result = this._adminService.Get(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}
