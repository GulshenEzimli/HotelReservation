using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private ITypesService _typesService;
        public TypesController(ITypesService typesService)
        {
            this._typesService = typesService;
        }
        [HttpPost("add")]
        public IActionResult Add(Types type)
        {
            var result = this._typesService.Add(type);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Types type)
        {
            var result = this._typesService.Update(type);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Delete(Types type)
        {
            var result = this._typesService.Delete(type);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Types, bool>>? filter)
        {
            var result = this._typesService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
