using System.Threading.Tasks;

namespace Product.CQ.Core
{
    public interface IQuery<TResult>
    {
        TResult Execute();

        Task<TResult> ExecuteAsync();
    }
}