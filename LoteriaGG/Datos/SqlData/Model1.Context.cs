﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.SqlData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LoteriaGGEntities : DbContext
    {
        public LoteriaGGEntities()
            : base("name=LoteriaGGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CODIGOS_PAGO_RUT> CODIGOS_PAGO_RUT { get; set; }
        public virtual DbSet<NUB_SORTEO_USUARIO> NUB_SORTEO_USUARIO { get; set; }
        public virtual DbSet<TBL_ADMIN> TBL_ADMIN { get; set; }
        public virtual DbSet<TBL_HOME> TBL_HOME { get; set; }
        public virtual DbSet<TBL_SORTEO> TBL_SORTEO { get; set; }
        public virtual DbSet<TBL_SORTEO_GRATIS> TBL_SORTEO_GRATIS { get; set; }
        public virtual DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }
        public virtual DbSet<TBL_CONTACTO> TBL_CONTACTO { get; set; }
    }
}
