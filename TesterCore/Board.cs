using System;
using System.Collections.Generic;

namespace TesterCore
{
    public partial class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoardTypeId { get; set; }
        public int CreatedById { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
