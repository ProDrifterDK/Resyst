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
    
        public virtual ICollection<NUB_SORTEO_USUARIO> NUB_SORTEO_USUARIO { get; set; }
        public virtual ICollection<TBL_ADMIN> TBL_ADMIN { get; set; }
    }
}
