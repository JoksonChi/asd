//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Club
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Collection = new HashSet<Collection>();
            this.PraiseRecord = new HashSet<PraiseRecord>();
            this.Reply = new HashSet<Reply>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string SysInfo { get; set; }
        public string Details { get; set; }
        public int ViewCount { get; set; }
        public int ReplyCount { get; set; }
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsAbort { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collection> Collection { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PraiseRecord> PraiseRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Reply { get; set; }
    }
}
