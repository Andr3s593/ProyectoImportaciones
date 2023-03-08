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
        public static void RegistroImportaciones(Importacion imprtEntr)
        {
            DBFuncionImportacionesEntities dbfuncionaimportacionesEntities = new DBFuncionImportacionesEntities();
            Importacion entradaImportacion = new Importacion();            
            entradaImportacion.NumeroImportacion = imprtEntr.NumeroImportacion;
            entradaImportacion.CodigoProducto = imprtEntr.CodigoProducto;
            entradaImportacion.NombreProducto = imprtEntr.NombreProducto;
            entradaImportacion.FechaImportacion = DateTime.Now;
            entradaImportacion.Proveedor = imprtEntr.Proveedor;
            entradaImportacion.Lote = imprtEntr.Lote;
            entradaImportacion.CantidadImportada = imprtEntr.CantidadImportada;
            entradaImportacion.CantidadRecibida = imprtEntr.CantidadRecibida;

            dbfuncionaimportacionesEntities.Importacion.Add(entradaImportacion);
            dbfuncionaimportacionesEntities.Entry(entradaImportacion).State = EntityState.Added;
            dbfuncionaimportacionesEntities.SaveChanges();

        }

        public static void RegistroEntradaSalidaImportaciones(EntradasSalidasImportacion imprtEntr)
        {
            DBFuncionImportacionesEntities dbfuncionaimportacionesEntities = new DBFuncionImportacionesEntities();
            EntradasSalidasImportacion salidaImportacion = new EntradasSalidasImportacion();
            salidaImportacion.CodigoCliente = imprtEntr.CodigoCliente;
            salidaImportacion.NombreCliente = imprtEntr.NombreCliente;
            salidaImportacion.NumeroFactura = imprtEntr.NumeroFactura;
            salidaImportacion.CantidadCompra = imprtEntr.CantidadCompra;
            salidaImportacion.NumeroImportacion = imprtEntr.NumeroImportacion;
            salidaImportacion.FechaSalidaImportacion = DateTime.Now;


            dbfuncionaimportacionesEntities.EntradasSalidasImportacion.Add(salidaImportacion);
            dbfuncionaimportacionesEntities.Entry(salidaImportacion).State = EntityState.Added;
            dbfuncionaimportacionesEntities.SaveChanges();
        }
        public static void RegistroProveedor(ProveedorImportacion proimpr) 
        { 
            DBFuncionImportacionesEntities dbfuncionimportacionesEntities = new DBFuncionImportacionesEntities();
            ProveedorImportacion proveedorImportacion = new ProveedorImportacion();
            proveedorImportacion.nombreProveedor = proimpr.nombreProveedor;

            dbfuncionimportacionesEntities.ProveedorImportacion.Add(proveedorImportacion);
            dbfuncionimportacionesEntities.Entry(proveedorImportacion).State = EntityState.Added;
            dbfuncionimportacionesEntities.SaveChanges();
        }
    }
}
