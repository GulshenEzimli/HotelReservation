using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResServicesController : ControllerBase
    {
        private IResServices_Service _resServices_Service ;
        public ResServicesController(IResServices_Service resServices_Service)
        {
            this._resServices_Service = resServices_Service;
        }
        [HttpPost("add")]
        public IActionResult Add(Res_Services res_Services)
        {
            var result = this._resServices_Service.Add(res_Services);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Res_Services res_Services)
        {
            var result = this._resServices_Service.Update(res_Services);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Res_Services res_Services)
        {
            var result = this._resServices_Service.Delete(res_Services);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Res_Services, bool>>? filter)
        {
            var result = this._resServices_Service.GetAll(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}
