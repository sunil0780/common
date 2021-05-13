namespace Product.CQ.Core
{
    public interface IParameterisedCommand<TParam> : ICommand
    {
        TParam GetParameter();

        TParam CreateParameter();

        void SetParameter(TParam parameter);
    }
}