﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NRP.KlientMvc.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NrpEntities : DbContext
    {
        public NrpEntities()
            : base("name=NrpEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Wersja> Wersja { get; set; }
    
        public virtual int ModyfikujStatus(Nullable<int> klientId, string statusId)
        {
            var klientIdParameter = klientId.HasValue ?
                new ObjectParameter("klientId", klientId) :
                new ObjectParameter("klientId", typeof(int));
    
            var statusIdParameter = statusId != null ?
                new ObjectParameter("statusId", statusId) :
                new ObjectParameter("statusId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModyfikujStatus", klientIdParameter, statusIdParameter);
        }
    }
}
