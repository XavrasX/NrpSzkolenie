namespace NRP.DataAcess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelKlient : DbContext
    {
        public ModelKlient()
            : base("name=ModelKlient")
        {
        }

        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Wersja> Wersja { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klient>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Klient>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Klient>()
                .HasMany(e => e.Wersja)
                .WithRequired(e => e.Klient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Wersja)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wersja>()
                .Property(e => e.DataModyfikacji)
                .HasPrecision(0);
        }
    }
}
