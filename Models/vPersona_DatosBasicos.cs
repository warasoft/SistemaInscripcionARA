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
    
    public partial class vPersona_DatosBasicos
    {
        public int IdPersona { get; set; }
        public Nullable<int> IdPostulante { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public int IdSexo { get; set; }
        public string Sexo { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Nullable<int> IdDelegacionOficinaIngresoInscribio { get; set; }
        public string Oficina { get; set; }
        public string ComoSeEntero { get; set; }
        public Nullable<int> IdComoSeEntero { get; set; }
        public string Opcion { get; set; }
        public Nullable<System.DateTime> EmpezoACargarDatos { get; set; }
        public Nullable<System.DateTime> PidioIngresoAlSist { get; set; }
        public Nullable<int> IdPreferencia { get; set; }
        public string NombreInst { get; set; }
        public string AspnetUser { get; set; }
        public Nullable<int> IdSecuencia { get; set; }
        public string Etapa_Estado { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> Edad { get; set; }
    }
}
