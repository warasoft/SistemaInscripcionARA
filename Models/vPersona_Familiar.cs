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
    
    public partial class vPersona_Familiar
    {
        public string Email { get; set; }
        public Nullable<int> IdFamiliar { get; set; }
        public int IdPersonaPostulante { get; set; }
        public Nullable<int> IdPersonaFamiliar { get; set; }
        public Nullable<int> idParentesco { get; set; }
        public Nullable<int> IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public string IdReligion { get; set; }
        public string Relacion { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public string EstCivil { get; set; }
        public Nullable<bool> Vive { get; set; }
        public Nullable<bool> ConVive { get; set; }
        public string Celular { get; set; }
        public string Mail { get; set; }
        public string DESCRIPCION { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> idTipoNacionalidad { get; set; }
        public string CUIL { get; set; }
        public Nullable<System.DateTime> FechaCasamiento { get; set; }
    }
}