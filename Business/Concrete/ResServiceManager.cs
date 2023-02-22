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
    public class ResServiceManager : IResServices_Service
    {
        private IRes_ServiceDal _res_ServiceDal;

        public ResServiceManager(IRes_ServiceDal res_ServiceDal)
        {
            _res_ServiceDal = res_ServiceDal;
        }

        [ValidationAspect(typeof(ResServices_Validator))]
        public IResult Add(Res_Services res_service)
        {
            _res_ServiceDal.Add(res_service);
            return new SuccessResult(Messages.ResServiceAdded);
        }

        public IResult Delete(Res_Services res_service)
        {
            _res_ServiceDal.Delete(res_service);
            return new SuccessResult(Messages.ResServiceDeleted);
        }

        public IDataResult<List<Res_Services>> GetAll(Expression<Func<Res_Services, bool>>? filter)
        {
            return new SuccessDataResult<List<Res_Services>>(_res_ServiceDal.GetAll(filter));
        }

        [ValidationAspect(typeof(ResServices_Validator))]
        public IResult Update(Res_Services res_service)
        {
            _res_ServiceDal.Update(res_service);
            return new SuccessResult(Messages.ReservationUpdated);
        }
    }
}
