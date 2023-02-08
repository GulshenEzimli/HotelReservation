using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRoomDal : EfEntityRepositoryBase<Room, HotelContext>, IRoomDal
    {
        public List<RoomDetails> GetRoomDetails(Expression<Func<Room, bool>> filter = null)
        {
            using(HotelContext context = new HotelContext())
            {
                var result = from r in filter == null ? context.Rooms :
                             context.Rooms.Where(filter)
                             join t in context.RoomTypes on r.TypeId equals t.Id
                             select new RoomDetails()
                             {
                                 Id = r.Id,
                                 Name = r.Name,
                                 TypeName = t.Name,
                                 Price = r.Price,
                                 Rate = r.Rate,
                                 MaxOccupants = r.MaxOccupants,
                             };
                return result.ToList();       
            }
        }
    }
}
