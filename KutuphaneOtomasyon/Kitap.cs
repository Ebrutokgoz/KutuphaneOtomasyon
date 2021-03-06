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
    
    public partial class Kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitap()
        {
            this.Emanet = new HashSet<Emanet>();
            this.Kitap_Kategori = new HashSet<Kitap_Kategori>();
            this.Kitap_Yayinevi = new HashSet<Kitap_Yayinevi>();
        }
    
        public int Kitap_id { get; set; }
        public string Kitap_ad { get; set; }
        public Nullable<int> Sayfa_sayisi { get; set; }
        public string ISBN { get; set; }
        public int Yazar_id { get; set; }
        public int Kütüphane_id { get; set; }
        public string Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emanet> Emanet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitap_Kategori> Kitap_Kategori { get; set; }
        public virtual Kutuphane Kutuphane { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitap_Yayinevi> Kitap_Yayinevi { get; set; }
        public virtual Yazarlar Yazarlar { get; set; }
    }
}
