using System.Threading.Tasks;

namespace Product.CQCore.Core
{
    public interface ICommand
    {
        void Execute();

        Task ExecuteAsync();
    }
}