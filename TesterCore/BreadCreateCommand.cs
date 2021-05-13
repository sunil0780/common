using Product.CQCore.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesterCore
{
    public class BoardCreateCommand : CreateCommand<Guid, Board>
    {
        public BoardCreateCommand() : base()
        {
        }
    }
}
