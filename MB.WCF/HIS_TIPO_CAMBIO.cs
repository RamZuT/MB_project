//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MB.WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class HIS_TIPO_CAMBIO
    {
        public int iIdTipoCambio { get; set; }
        public decimal vMonto { get; set; }
        public Nullable<System.DateTime> dFecha { get; set; }
        public Nullable<int> iIdMoneda { get; set; }
    
        public virtual MONEDA MONEDA { get; set; }
    }
}
