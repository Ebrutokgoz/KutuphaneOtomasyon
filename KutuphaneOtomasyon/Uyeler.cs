//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uyeler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uyeler()
        {
            this.Kutuphane_Uye = new HashSet<Kutuphane_Uye>();
        }
    
        public int Uye_id { get; set; }
        public string Uye_ad { get; set; }
        public string Uye_soyad { get; set; }
        public string Uye_eposta { get; set; }
        public string Uye_telefon { get; set; }
        public int Ceza { get; set; }
        public int Max_kitap_sayisi { get; set; }
        public int Alınan_kitap_sayisi { get; set; }
    
        public virtual Emanet Emanet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kutuphane_Uye> Kutuphane_Uye { get; set; }
    }
}