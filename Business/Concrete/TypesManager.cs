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
    public class TypesManager : ITypesService
    {
        private ITypesDal _typesDal;
        public TypesManager(ITypesDal typesDal)
        {
            _typesDal = typesDal;
        }

        [ValidationAspect(typeof(TypesValidator))]
        public IResult Add(Types types)
        {
            _typesDal.Add(types);
            return new SuccessResult(Messages.TypeAdded);
        }

        public IResult Delete(Types types)
        {
            _typesDal.Delete(types);
            return new SuccessResult(Messages.TypeDeleted);
        }

        public IDataResult<List<Types>> GetAll(Expression<Func<Types, bool>>? filter)
        {
            return new SuccessDataResult<List<Types>>(_typesDal.GetAll(filter));
        }

        [ValidationAspect(typeof(TypesValidator))]
        public IResult Update(Types types)
        {
            _typesDal.Update(types);
            return new SuccessResult(Messages.TypeUpdated);
        }
    }
}
