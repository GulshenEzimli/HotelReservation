using Core.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IContactService
    {
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
        IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>>? filter);
        IDataResult<List<ContactDetails>> GetContactDetails();
        IDataResult<Contact> Get(Expression<Func<Contact, bool>> filter);
    }
}
