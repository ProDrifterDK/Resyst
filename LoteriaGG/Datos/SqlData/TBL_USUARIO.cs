//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.SqlData
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_USUARIO
    {
        public TBL_USUARIO()
        {
            this.CODIGOS_PAGO_RUT = new HashSet<CODIGOS_PAGO_RUT>();
            this.NUB_SORTEO_USUARIO = new HashSet<NUB_SORTEO_USUARIO>();
            this.TBL_ADMIN = new HashSet<TBL_ADMIN>();
        }
    
        public long USU_ID { get; set; }
        public string USU_NOMBRE { get; set; }
        public string USU_APELLIDO { get; set; }
        public string USU_ACCOUNT { get; set; }
        public string USU_PASSWORD { get; set; }
        public string USU_EMAIL { get; set; }
        public string USU_SUMMONER { get; set; }
        public Nullable<System.Guid> USU_CODIGO_VERIFICAION { get; set; }
        public Nullable<bool> USU_VERIFICADO { get; set; }
        public Nullable<double> USU_SOR_DISP { get; set; }
        public Nullable<bool> USU_CAMBIO_EMAIL { get; set; }
        public Nullable<bool> USU_SORTEO_ESPECIAL { get; set; }
        public string USU_STEAM_NICK { get; set; }
        public Nullable<System.DateTime> USU_DAILY_REWARD { get; set; }
        public Nullable<int> USU_DAILY { get; set; }
        public bool USU_PAGADO { get; set; }
        public bool USU_USO_REFER { get; set; }
        public string USU_REFER_CODIGO { get; set; }
        public int USU_CANT_REFERIDA { get; set; }
        public Nullable<long> USU_REFERENTE { get; set; }
    
        public virtual ICollection<CODIGOS_PAGO_RUT> CODIGOS_PAGO_RUT { get; set; }
        public virtual ICollection<NUB_SORTEO_USUARIO> NUB_SORTEO_USUARIO { get; set; }
        public virtual ICollection<TBL_ADMIN> TBL_ADMIN { get; set; }
    }
}
