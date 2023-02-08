using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRoomDal : IEntityRepository<Room>
    {
        List<RoomDetails> GetRoomDetails(Expression<Func<Room, bool>> filter = null);
    }
}
