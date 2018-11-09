using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioProveedores
    {
        accesoDatosProveedores ap = new accesoDatosProveedores();
        public int insertarProveedores(proveedores pv)
        {
            return ap.insertarProveedores(pv);
        }
        public List<proveedores> ListarProveedores()
        {
            return ap.ListarProveedores();
        }
        public int EditarProveedor(proveedores pv)
        {
            return ap.EditarProveedor(pv);
        }
        public int EliminarProveedor(int idproveedor)
        {
            return ap.EliminarProveedor(idproveedor);
        }
        public proveedores BuscarProveedorXcodigo(int idpro)
        {
            return ap.BuscarProveedorXcodigo(idpro);
        }
        public List<proveedores> BuscaProveedorDatos(string dato)
        {
            return ap.BuscaProveedorDatos(dato);
        }
    }
}
