using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        public bool dataPosted { get; set; }
        public int UserId { get; set; }
    }
}
