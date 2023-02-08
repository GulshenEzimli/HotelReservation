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
    public interface IResServices_Service
    {
        IResult Add(Res_Services res_service);
        IResult Update(Res_Services res_service);
        IResult Delete(Res_Services res_service);
        IDataResult<List<Res_Services>> GetAll(Expression<Func<Res_Services,bool>>? filter);
    }
}
