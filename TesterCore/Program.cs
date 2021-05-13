using System;
using System.Linq;
using System.Threading.Tasks;

using Product.CQCore.Base;
using Product.CQCore.Core;
using Product.RepositoryCore.Base;
using Product.RepositoryCore.Core;

namespace TesterCore
{
    public class Program
    {
        private static void Main(string[] args)
        {
            iaso_v001Context context = new iaso_v001Context();

            ICommandRepository<Guid, Board> boardCommandRepo = new CommandRepository<Guid, Board>(context);

            IQueryRepository<Guid, Board> boardQueryRepo = new QueryRepository<Guid, Board>(context);

            IParameterisedQuery<int, Board> pQuery = new PQ();

            var b = pQuery.GetParameter();

            var boardList = boardQueryRepo.Items.ToList();

            foreach (var t in boardList.ToList())
            {
                Console.WriteLine(string.Format("{0} >>>> {1}", t.Id, t.Name));
            }

            var board = new Board
            {
                Id = 1,
                Name = "No Base 21/03",
                BoardTypeId = 1,
                CreateDate = DateTime.Now,
                CreatedById = 1
            };


            ISaveCommand<Board> createCom = new CreateCommand<Guid, Board>()
            {
                Entity = board,
                Repository = new CommandRepository<Guid, Board>(context)
            };

            var task = Task.Run(() => createCom.ExecuteAsync());

            task.Wait();

            try
            {
                IDeleteCommand<int> deleteCommand = new DeleteCommand<int, Board>()
                {

                    Repository = new CommandRepository<int, Board>(context)
                };

                deleteCommand.Id = 1;

                var tk = Task.Run(() => deleteCommand.ExecuteAsync());

                tk.Wait();
            }
            catch (Exception ex)
            {
            }
            Console.ReadKey();
        }
    }

    public class PQ : ParameterisedQuery<int, Board>
    {
        public override Board Execute()
        {
            throw new NotImplementedException();
        }

        public override Task<Board> ExecuteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
