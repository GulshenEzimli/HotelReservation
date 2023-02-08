using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class RoomDetails : IDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }
        public decimal Price { get; set; }
        public decimal Rate { get; set; }
        public int MaxOccupants { get; set; }
        public bool RoomLock { get; set; }
    }
}
