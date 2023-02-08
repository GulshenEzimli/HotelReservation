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
    public interface ITypesService
    {
        IResult Add(Types types);
        IResult Update(Types types);
        IResult Delete(Types types);
        IDataResult<List<Types>> GetAll(Expression<Func<Types,bool>>? filter);
    }
}
