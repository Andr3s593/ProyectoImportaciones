//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyectoimportaciones_v1
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntradaImportacion
    {
        public int id { get; set; }
        public string NumeroImportacion { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Lote { get; set; }
        public Nullable<System.DateTime> FechaImportacion { get; set; }
        public string Proveedor { get; set; }
        public Nullable<decimal> CantidadImportada { get; set; }
        public Nullable<decimal> CantidadRecibida { get; set; }
    }
}
