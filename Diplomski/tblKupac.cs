//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikacijaZaPracenjePorudzbina
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKupac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKupac()
        {
            this.tblPorudzbinas = new HashSet<tblPorudzbina>();
        }
    
        public int kupacID { get; set; }
        public string ime { get; set; }
        public string korisnickoIme { get; set; }
        public string sifra { get; set; }
        public Nullable<bool> admin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPorudzbina> tblPorudzbinas { get; set; }
    }
}