//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Franthesk.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA()
        {
            this.MERCADORIA_VENDA = new HashSet<MERCADORIA_VENDA>();
        }
    
        public int CD_ID { get; set; }
        public string NM_Vendedor { get; set; }
        public string DT_Data { get; set; }
        public Nullable<double> VL_ValorTotal { get; set; }
        public Nullable<int> CD_Cartao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MERCADORIA_VENDA> MERCADORIA_VENDA { get; set; }
    }
}