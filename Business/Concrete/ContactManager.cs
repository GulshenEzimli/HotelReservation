using Business.Abstract;
using Business.Constants;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        [ValidationAspect(typeof(ContactValidator))]
        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult(Messages.ContactDeleted);
        }

        public IDataResult<Contact> Get(Expression<Func<Contact, bool>> filter)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(filter));
        }

        public IDataResult<List<Contact>> GetAll(Expression<Func<Contact, bool>>? filter)
        {
            return  new SuccessDataResult<List<Contact>>(_contactDal.GetAll(filter));
        }

        public IDataResult<List<ContactDetails>> GetContactDetails()
        {
            return new SuccessDataResult<List<ContactDetails>>(_contactDal.GetContactDetails());
        }

        [ValidationAspect(typeof(ContactValidator))]
        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult(Messages.ContactUpdated);
        }
    }
}
