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
    public class EfContactDal : EfEntityRepositoryBase<Contact, HotelContext>, IContactDal
    {
        public List<ContactDetails> GetContactDetails(Expression<Func<Contact, bool>> filter = null)
        {
            using(HotelContext context = new HotelContext())
            {
                var result = from c in filter == null ? context.Contacts
                             : context.Contacts.Where(filter)
                             join u in context.Users on c.UserId equals u.Id
                             select new ContactDetails()
                             {
                                 Id = c.Id,
                                 Heading = c.Heading,
                                 Content = c.Content,
                                 dataPosted = c.dataPosted,
                                 UserName = u.Username,
                             };
                return result.ToList();
            }
        }
    }
}
