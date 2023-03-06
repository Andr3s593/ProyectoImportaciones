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
            entradaImportacion.Lote = imprtEntr.Lote;
            entradaImportacion.CantidadImportada = imprtEntr.CantidadImportada;
            entradaImportacion.CantidadRecibida = imprtEntr.CantidadRecibida;

            dbfuncionaimportacionesEntities.EntradaImportacion.Add(entradaImportacion);
            dbfuncionaimportacionesEntities.Entry(entradaImportacion).State = EntityState.Added;
            dbfuncionaimportacionesEntities.SaveChanges();

        }

        public static void RegistroImportacionesSalidas(SalidaImportacion imprtEntr)
        {
            DBFuncionImportacionesEntities dbfuncionaimportacionesEntities = new DBFuncionImportacionesEntities();
            SalidaImportacion salidaImportacion = new SalidaImportacion();
            salidaImportacion.CodigoCliente = imprtEntr.CodigoCliente;
            salidaImportacion.NombreCliente = imprtEntr.NombreCliente;
            salidaImportacion.NumeroFactura = imprtEntr.NumeroFactura;
            salidaImportacion.CantidadCompra = imprtEntr.CantidadCompra;
            salidaImportacion.NumeroImportacion = imprtEntr.NumeroImportacion;
            salidaImportacion.FechaSalidaImportacion = DateTime.Now;


            dbfuncionaimportacionesEntities.SalidaImportacion.Add(salidaImportacion);
            dbfuncionaimportacionesEntities.Entry(salidaImportacion).State = EntityState.Added;
            dbfuncionaimportacionesEntities.SaveChanges();
        }
    }
}
