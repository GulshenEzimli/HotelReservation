using Business.Abstract;
using Business.Constants;
using Business.CrossCuttingConcerns.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public IResult Add(Reservation reservation)
        {
            ValidatorTool.Validate(reservation, new ReservationValidator());
            _reservationDal.Add(reservation);
            return new SuccessResult(Messages.ReservationAdded);
        }

        public IResult Delete(Reservation reservation)
        {
            _reservationDal.Delete(reservation);
            return new SuccessResult(Messages.ReservationDeleted);
        }

        public IDataResult<Reservation> Get(Expression<Func<Reservation, bool>> filter)
        {
            return new SuccessDataResult<Reservation>(_reservationDal.Get(filter));
        }

        public IDataResult<List<Reservation>> GetAll(Expression<Func<Reservation, bool>>? filter)
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetAll(filter));
        }

        public IDataResult<List<ReservationDetails>> GetReservationDetails()
        {
            return new SuccessDataResult<List<ReservationDetails>>(_reservationDal.GetReservationDetails());
        }

        public IResult Update(Reservation reservation)
        {
            ValidatorTool.Validate(reservation, new ReservationValidator());
            _reservationDal.Update(reservation);
            return new SuccessResult(Messages.ReservationUpdated);
        }
    }
}
