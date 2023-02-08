using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private IService_Service _service_Service;
        public ServicesController(IService_Service service_Service)
        {
            this._service_Service = service_Service;
        }
        [HttpPost("add")]
        public IActionResult Add(Service service)
        {
            var result = this._service_Service.Add(service);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Service service)
        {
            var result = this._service_Service.Update(service);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Service service)
        {
            var result = this._service_Service.Delete(service);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Service, bool>>? filter)
        {
            var result = this._service_Service.GetAll(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Service, bool>> filter)
        {
            var result = this._service_Service.Get(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}
