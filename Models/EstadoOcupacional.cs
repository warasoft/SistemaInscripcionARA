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
    
    public partial class EstadoOcupacional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoOcupacional()
        {
            this.SituacionOcupacional = new HashSet<SituacionOcupacional>();
        }
    
        public int Id { get; set; }
        public string EstadoOcupacional1 { get; set; }
        public string Descripcion { get; set; }
        public bool CargaOcupacionActual { get; set; }
        public string Explicacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SituacionOcupacional> SituacionOcupacional { get; set; }
    }
}