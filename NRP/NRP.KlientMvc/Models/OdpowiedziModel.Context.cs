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

    public partial class NrpOdpowiedziEntities : DbContext
    {
        public NrpOdpowiedziEntities()
            : this("NrpOdpowiedziEntities")
        {
        }

        public NrpOdpowiedziEntities(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<v_Form_Odpowiedzi> v_Form_Odpowiedzi { get; set; }
        public virtual DbSet<WersjaPola> WersjaPola { get; set; }

        object placeHolderVariable;
    }
}
