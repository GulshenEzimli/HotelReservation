using Core.Results.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll(Expression<Func<User,bool>>? filter);
        IDataResult<User> Get(Expression<Func<User, bool>> filter);
    }
}
