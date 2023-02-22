using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (typeof(IValidator).IsAssignableFrom(validatorType))
                this._validatorType = validatorType;
            else throw new Exception("Parameter must be assingable from IValidator");
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(this._validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(a => a.GetType() == entityType).ToList();

            foreach (var entity in entities)
            {
                ValidatorTool.Validate(entity, validator);
            }
        }
    }
}
