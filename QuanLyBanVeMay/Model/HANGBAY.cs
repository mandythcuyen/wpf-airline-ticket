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
    
    public partial class HANGBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGBAY()
        {
            this.CHUYENBAYs = new HashSet<CHUYENBAY>();
        }
    
        public string HANGBAYID { get; set; }
        public string TEN { get; set; }
        public string HOTLINE { get; set; }
        public string DCHIVP { get; set; }
        public string EMAIL { get; set; }
        public string THONGTIN { get; set; }
        public System.DateTime NGHOPTAC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENBAY> CHUYENBAYs { get; set; }
    }
}
