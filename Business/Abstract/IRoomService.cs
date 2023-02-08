using Core.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IResult Add(Room room);
        IResult Update(Room room);
        IResult Delete(Room room);
        IDataResult<List<Room>> GetAll(Expression<Func<Room,bool>>? filter);
        IDataResult<List<RoomDetails>> GetRoomDetails();
        IDataResult<Room> Get(Expression<Func<Room, bool>> filter);
    }
}
