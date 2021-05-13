using System;
using System.Threading.Tasks;

using Product.CQCore.Core;

namespace Product.CQCore.Base
{
    public abstract class ParameterisedQuery<TParam, TResult> : IParameterisedQuery<TParam, TResult>
    {
        public abstract TResult Execute();

        public abstract Task<TResult> ExecuteAsync();

        protected TParam Parameter { get; set; }

        public TParam GetParameter()
        {
            if (Parameter == null)
            {
                Parameter = (TParam)Activator.CreateInstance(typeof(TParam));
            }

            return Parameter;
        }

        public TParam CreateParameter()
        {
            return (TParam)Activator.CreateInstance(typeof(TParam));
        }

        public void SetParameter(TParam parameter)
        {
            Parameter = parameter;
        }
    }
}
