using Product.CQ.Base;
using Product.CQ.Core;
using Product.Repository.Base;
using Product.Repository.Core;
using System;
using System.Threading.Tasks;

namespace Tester
{
    public class Program
    {
        private static void Main(string[] args)
        {
            iaso_v001Entities context = new iaso_v001Entities();

            ICommandRepository<Guid, Board> boardCommandRepo = new CommandRepository<Guid, Board>(context);

            IQueryRepository<Guid, Board> boardQueryRepo = new QueryRepository<Guid, Board>(context);

            //IParameterisedQuery<int, Board> pQuery = new PQ();

            //var b = pQuery.GetParameter();

            //var boardList = boardQueryRepo.Items.ToList();

            //foreach (var b in boardList.ToList())
            //{
            //    Console.WriteLine(string.Format("{0} >>>> {1}", b.Id, b.Name));
            //}

            var board = new Board
            {
                Id = Guid.NewGuid(),
                Name = "No Base 21/03",
                BoardTypeId = new Guid("6F2BF38C-44D1-E611-A83D-D067E5F29371"),
                CreatedDateTime = DateTime.Now,
                CreatedBy_Id = new Guid("0191FBDF-40D1-E611-A83D-D067E5F29371")
            };

            ISaveCommand<Board> createCom = new CreateCommand<Guid, Board>()
            {
                Entity = board,
                Repository = new CommandRepository<Guid, Board>(context)
            };

            var task = Task.Run(() => createCom.ExecuteAsync());

            task.Wait();

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