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
    
    public partial class tblStavkaPorudzbine
    {
        public int stavkaPorudzbineID { get; set; }
        public Nullable<int> redniBroj { get; set; }
        public Nullable<decimal> kolicina { get; set; }
        public string jedinicaMere { get; set; }
        public Nullable<decimal> cena { get; set; }
        public Nullable<int> porudzbinaID { get; set; }
        public Nullable<int> artiklID { get; set; }
    
        public virtual tblArtikl tblArtikl { get; set; }
        public virtual tblPorudzbina tblPorudzbina { get; set; }
    }
}