 var status {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Status() {
        this.Wersja = new HashSet<Wersja>();
    }

    public int Id { get; set; }
        public string Nazwa { get; set; }

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection < Wersja > Wersja { get; set; }
    }