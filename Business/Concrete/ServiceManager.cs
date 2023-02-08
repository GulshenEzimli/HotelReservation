using Business.Abstract;
using Business.Constants;
using Business.CrossCuttingConcerns.Validation;
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
    public class ServiceManager : IService_Service
    {
        private IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public IResult Add(Service service)
        {
            ValidatorTool.Validate(service, new ServiceValidator());
            _serviceDal.Add(service);
            return new SuccessResult(Messages.ServiceAdded);
        }

        public IResult Delete(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult(Messages.ServiceDeleted);
        }

        public IDataResult<Service> Get(Expression<Func<Service, bool>> filter)
        {
            return new SuccessDataResult<Service>(_serviceDal.Get(filter));
        }

        public IDataResult<List<Service>> GetAll(Expression<Func<Service, bool>>? filter)
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetAll(filter));
        }

        public IResult Update(Service service)
        {
            ValidatorTool.Validate(service, new ServiceValidator());
            _serviceDal.Update(service);
            return new SuccessResult(Messages.ServiceUpdated);
        }
    }
}
