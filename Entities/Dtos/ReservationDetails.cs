using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ReservationDetails : IDtos
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string RoomName { get; set; }
        public bool checkIn { get; set; }
        public DateTime res_Date { get; set; }
        public decimal totalCost { get; set; }
        public int dayCount { get; set; }
    }
}
