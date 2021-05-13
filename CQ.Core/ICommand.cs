using System.Threading.Tasks;

namespace Product.CQ.Core
{
    public interface ICommand
    {
        void Execute();

        Task ExecuteAsync();
    }
}