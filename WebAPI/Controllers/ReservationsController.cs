using Business.Abstract;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private IReservationService _reservationService;
        public ReservationsController(IReservationService reservationService)
        {
            this._reservationService = reservationService;
        }
        [HttpPost("add")]
        public IActionResult Add(Reservation reservation)
        {
            var result = this._reservationService.Add(reservation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Reservation reservation)
        {
            var result = this._reservationService.Update(reservation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Reservation reservation)
        {
            var result = this._reservationService.Delete(reservation);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Reservation,bool>>? filter)
        {
            var result = this._reservationService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Reservation, bool>> filter)
        {
            var result = this._reservationService.Get(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getdetails")]
        public IActionResult GetReservationDetails(Expression<Func<Reservation, bool>>? filter)
        {
            var result = this._reservationService.GetReservationDetails(filter);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
