//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tester
{
    using System;
    using System.Collections.Generic;
    
    public partial class Card
    {
        public System.Guid Id { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public System.Guid BoardId { get; set; }
        public System.Guid LaneId { get; set; }
        public System.DateTimeOffset CreatedDateTime { get; set; }
        public Nullable<System.DateTimeOffset> UpdateDateTime { get; set; }
        public System.Guid CreatedBy_Id { get; set; }
        public Nullable<System.Guid> UpdatedBy_Id { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Board Board { get; set; }
    }
}
