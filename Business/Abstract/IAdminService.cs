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
    public interface IAdminService
    {
        IResult Add(Admin admin);
        IResult Update(Admin admin);
        IResult Delete(Admin admin);
        IDataResult<List<Admin>> GetAll(Expression<Func<Admin, bool>>? filter);
        IDataResult<Admin> Get(Expression<Func<Admin, bool>> filter);
    }
}
