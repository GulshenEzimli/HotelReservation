using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation,Exception ex) { }


        public override void Intercept(IInvocation invocation)
        {
            var isSucceed = true;
            this.OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception exception)
            {
                isSucceed = false;
                this.OnException(invocation, exception);
                throw;
            }
            finally
            {
                if (isSucceed) this.OnSuccess(invocation);
            }
            this.OnAfter(invocation);
        }
    }
}
