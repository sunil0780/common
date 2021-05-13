using System.Threading.Tasks;

namespace Product.CQCore.Core
{
    public interface IQuery<TResult>
    {
        TResult Execute();

        Task<TResult> ExecuteAsync();
    }
}