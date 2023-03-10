using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public bool checkIn { get; set; }
        public DateTime res_Date { get; set; }
        public decimal totalCost { get; set; }
        public int dayCount { get; set; }
    }
}
