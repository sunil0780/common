using Product.CQ.Core;
using System;
using System.Threading.Tasks;

namespace Product.CQ.Base
{
    public abstract class ParameterisedCommand<TParam> : IParameterisedCommand<TParam>
    {
        public abstract void Execute();

        public abstract Task ExecuteAsync();

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