//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanVeMay.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHUYENBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYENBAY()
        {
            this.CHITIETLICHTRINHBAYs = new HashSet<CHITIETLICHTRINHBAY>();
            this.LICHTRINHBAYs = new HashSet<LICHTRINHBAY>();
        }
    
        public int CHUYENBAYID { get; set; }
        public System.DateTime GIOKHOIHANHTHUCTE { get; set; }
        public System.DateTime GIODENDUKIEN { get; set; }
        public string MACHUYENBAY { get; set; }
        public string HANG { get; set; }
        public string MAYBAY { get; set; }
        public string GOIDICHVU { get; set; }
        public string HANHLYXACHTAY { get; set; }
        public string HANHLYKIGOI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETLICHTRINHBAY> CHITIETLICHTRINHBAYs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHTRINHBAY> LICHTRINHBAYs { get; set; }
        public virtual HANGBAY HANGBAY { get; set; }
    }
}
