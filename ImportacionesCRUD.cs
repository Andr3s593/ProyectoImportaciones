using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoimportaciones_v1
{
    public class ImportacionesCRUD
    {
        public static void RegistroImportacionesEntradas(EntradaImportacion imprtEntr)
        {
            DBFuncionImportacionesEntities dbfuncionaimportacionesEntities = new DBFuncionImportacionesEntities();
            EntradaImportacion entradaImportacion = new EntradaImportacion();            
            entradaImportacion.NumeroImportacion = imprtEntr.NumeroImportacion;
            entradaImportacion.CodigoProducto = imprtEntr.CodigoProducto;
            entradaImportacion.NombreProducto = imprtEntr.NombreProducto;
            entradaImportacion.FechaImportacion = DateTime.Now;
            entradaImportacion.Proveedor = imprtEntr.Proveedor;
            entradaImportacion.CantidadImportada = imprtEntr.CantidadImportada;
            entradaImportacion.CantidadRecibida = imprtEntr.CantidadRecibida;

            dbfuncionaimportacionesEntities.EntradaImportacion.Add(entradaImportacion);
            dbfuncionaimportacionesEntities.Entry(entradaImportacion).State = EntityState.Added;
            dbfuncionaimportacionesEntities.SaveChanges();

        }
    }
}
