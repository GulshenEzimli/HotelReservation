using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService_Service
    {
        IResult Add(Service service);
        IResult Update(Service service);
        IResult Delete(Service service);
        IDataResult<List<Service>> GetAll(Expression<Func<Service, bool>>? filter);
        IDataResult<Service> Get(Expression<Func<Service, bool>> filter);
    }
}
