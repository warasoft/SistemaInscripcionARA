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
    
    public partial class vInscripcionEtapaEstadoUltimoEstado
    {
        public int IdSecuencia { get; set; }
        public string Etapa { get; set; }
        public string Estado { get; set; }
        public int IdInscripcionEtapaEstado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Email { get; set; }
        public string Delegacion { get; set; }
        public Nullable<int> IdDelegacionOficinaIngresoInscribio { get; set; }
        public string IdModalidad { get; set; }
        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public Nullable<System.DateTime> FechaRindeExamen { get; set; }
        public Nullable<System.DateTime> FechaEntrevista { get; set; }
        public Nullable<System.DateTime> FechaInscripcion { get; set; }
        public int IdDomicilioDNI { get; set; }
        public int IdDomicilioActual { get; set; }
        public Nullable<bool> Activa { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio_Proceso { get; set; }
        public Nullable<System.DateTime> Fecha_Fin_Proceso { get; set; }
        public string DNI { get; set; }
    }
}
