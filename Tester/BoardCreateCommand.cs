using Product.CQ.Base;
using System;

namespace Tester
{
    public class BoardCreateCommand : CreateCommand<Guid, Board>
    {
        public BoardCreateCommand() : base()
        {
        }
    }
}