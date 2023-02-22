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
    public class EfReservationDal : EfEntityRepositoryBase<Reservation, HotelContext>, IReservationDal
    {
        public List<ReservationDetails> GetReservationDetails(Expression<Func<Reservation, bool>>? filter)
        {
            using (HotelContext context = new HotelContext())
            {
                var result = from res in filter == null ? context.Reservations
                             : context.Reservations.Where(filter)
                             join r in context.Rooms
                             on res.RoomId equals r.Id
                             join u in context.Users
                             on res.UserId equals u.Id
                             select new ReservationDetails()
                             {
                                 Id = res.Id,
                                 UserName = u.Username,
                                 RoomName = r.Name,
                                 checkIn = res.checkIn,
                                 res_Date = res.res_Date,
                                 dayCount = res.dayCount,
                                 totalCost = res.totalCost,
                             };
                return result.ToList();
            }
        }
    }
}
