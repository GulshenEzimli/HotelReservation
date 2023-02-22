using Business.Abstract;
using Business.Constants;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;
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
    public class RoomManager : IRoomService
    {
        private IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        [ValidationAspect(typeof(RoomValidator))]
        public IResult Add(Room room)
        {
            _roomDal.Add(room);
            return new SuccessResult(Messages.RoomAdded);
        }

        public IResult Delete(Room room)
        {
            _roomDal.Delete(room);
            return new SuccessResult(Messages.RoomDeleted);
        }

        public IDataResult<Room> Get(Expression<Func<Room, bool>> filter)
        {
            return new SuccessDataResult<Room>(_roomDal.Get(filter));
        }

        public IDataResult<List<Room>> GetAll(Expression<Func<Room,bool>>? filter)
        {
            return new SuccessDataResult<List<Room>>(_roomDal.GetAll(filter));
        }

        public IDataResult<List<RoomDetails>> GetRoomDetails(Expression<Func<Room, bool>>? filter)
        {
            return new SuccessDataResult<List<RoomDetails>>(_roomDal.GetRoomDetails(filter));
        }

        [ValidationAspect(typeof(RoomValidator))]
        public IResult Update(Room room)
        {
            _roomDal.Update(room);
            return new SuccessResult(Messages.RoomUpdated);
        }
    }
}
