//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SINU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Secuencia_EtapaEstado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Secuencia_EtapaEstado()
        {
            this.InscripcionEtapaEstado = new HashSet<InscripcionEtapaEstado>();
        }
    
        public int IdSecuencia { get; set; }
        public int IdEtapa { get; set; }
        public int IdEstado { get; set; }
        public int Anterior { get; set; }
        public int Siguiente { get; set; }
        public bool Estacional { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Etapa Etapa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InscripcionEtapaEstado> InscripcionEtapaEstado { get; set; }
    }
}
