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
    
    public partial class Board
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Board()
        {
            this.Participants = new HashSet<AspNetUser>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public System.Guid BoardTypeId { get; set; }
        public System.DateTimeOffset CreatedDateTime { get; set; }
        public Nullable<System.DateTimeOffset> UpdateDateTime { get; set; }
        public System.Guid CreatedBy_Id { get; set; }
        public Nullable<System.Guid> UpdatedBy_Id { get; set; }
    
        public virtual BoardType BoardType { get; set; }
        public virtual AspNetUser CreatedBy { get; set; }
        public virtual AspNetUser UpdatedBy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> Participants { get; set; }
    }
}