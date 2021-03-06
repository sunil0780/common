namespace Product.CQ.Core
{
    public interface IParameterisedQuery<TParam, TResult> : IQuery<TResult>
    {
        TParam GetParameter();

        TParam CreateParameter();

        void SetParameter(TParam parameter);
    }
}