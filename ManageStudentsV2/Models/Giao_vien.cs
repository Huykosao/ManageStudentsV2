//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageStudentsV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Giao_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giao_vien()
        {
            this.Lop_chinh = new HashSet<Lop_chinh>();
            this.Lop_hoc_phan = new HashSet<Lop_hoc_phan>();
        }
    
        public int ma_giao_vien { get; set; }
        public string ten_giao_vien { get; set; }
        public Nullable<int> ma_khoa { get; set; }
    
        public virtual Khoa Khoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lop_chinh> Lop_chinh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lop_hoc_phan> Lop_hoc_phan { get; set; }
    }
}
