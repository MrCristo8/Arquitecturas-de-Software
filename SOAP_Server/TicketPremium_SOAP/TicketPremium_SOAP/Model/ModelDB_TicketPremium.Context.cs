﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketPremium_SOAP.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ticketpremiumEntities : DbContext
    {
        public ticketpremiumEntities()
            : base("name=ticketpremiumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TECLI_CLIENT> TECLI_CLIENT { get; set; }
        public virtual DbSet<TEDEF_DETFAC> TEDEF_DETFAC { get; set; }
        public virtual DbSet<TEFAC_FACTUR> TEFAC_FACTUR { get; set; }
        public virtual DbSet<TELCP_LOCPTD> TELCP_LOCPTD { get; set; }
        public virtual DbSet<TEPAF_PARFUT> TEPAF_PARFUT { get; set; }
    }
}
