//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NRP.DataAcess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wersja
    {
        public int Id { get; set; }
        public int KlientId { get; set; }
        public int StatusId { get; set; }
        public System.DateTime DataModyfikacji { get; set; }
        public string PracownikId { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Status Status { get; set; }
    }
}
