using Business.Abstract;
using Business.Constants;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        [ValidationAspect(typeof(AdminValidator))]
        public IResult Add(Admin admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult(Messages.AdminAdded);
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(Messages.AdminDeleted);
        }

        public IDataResult<List<Admin>> GetAll(Expression<Func<Admin, bool>>? filter)
        {
            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll(filter));
        }
        public IDataResult<Admin> Get(Expression<Func<Admin, bool>> filter)
        {
            return new SuccessDataResult<Admin>(_adminDal.Get(filter));
        }
        [ValidationAspect(typeof(AdminValidator))]
        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(Messages.AdminUpdated);
        }
    }
}
