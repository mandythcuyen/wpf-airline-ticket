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
    
    public partial class LICHTRINHBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHTRINHBAY()
        {
            this.BANGTRATHONGTINVEs = new HashSet<BANGTRATHONGTINVE>();
            this.CHITIETLICHTRINHBAYs = new HashSet<CHITIETLICHTRINHBAY>();
            this.VEs = new HashSet<VE>();
        }
    
        public int LICHTRINHBAYID { get; set; }
        public System.DateTime GIOKHOIHANHDUKIEN { get; set; }
        public double TGBAYDUKIEN { get; set; }
        public string SBDI { get; set; }
        public string SBDEN { get; set; }
        public Nullable<int> CHUYENBAYID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGTRATHONGTINVE> BANGTRATHONGTINVEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETLICHTRINHBAY> CHITIETLICHTRINHBAYs { get; set; }
        public virtual CHUYENBAY CHUYENBAY { get; set; }
        public virtual SANBAY SANBAY { get; set; }
        public virtual SANBAY SANBAY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}