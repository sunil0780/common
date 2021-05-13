namespace Product.CQCore.Core
{
    public interface IParameterisedCommand<TParam> : ICommand
    {
        TParam GetParameter();

        TParam CreateParameter();

        void SetParameter(TParam parameter);
    }
}