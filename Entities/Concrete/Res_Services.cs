using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Res_Services : IEntity
    {
        public int Id { get; set; }
        public int Res_Id { get; set; }
        public int Ser_Id { get; set; }
        public int Quantity { get; set; }
    }
}
