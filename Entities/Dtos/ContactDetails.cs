using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ContactDetails : IDtos
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        public bool dataPosted { get; set; }
        public string UserName { get; set; }
    }
}
