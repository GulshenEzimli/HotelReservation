using Core.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IReservationService
    {
        IResult Add(Reservation reservation);
        IResult Update(Reservation reservation);
        IResult Delete(Reservation reservation);
        IDataResult<List<Reservation>> GetAll(Expression<Func<Reservation, bool>>? filter);
        IDataResult<Reservation> Get(Expression<Func<Reservation,bool>> filter);
        IDataResult<List<ReservationDetails>> GetReservationDetails(Expression<Func<Reservation, bool>>? filter);
    }

}
