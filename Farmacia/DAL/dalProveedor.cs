using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalProveedor {
        public void insertar_proveedor(clsProveedor xpv) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "proveedor_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@nombre", xpv.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xpv.descripcion);
            xcon.cmd.Parameters.AddWithValue("@telefono", xpv.telefono);
            xcon.cmd.Parameters.AddWithValue("@direccion", xpv.direccion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsProveedor seleccionar_proveedor(int proveedor) {
            clsProveedor xpv = new clsProveedor();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "proveedor_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@proveedor", proveedor);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xpv.id = reader.GetInt32(0);
                xpv.nombre = reader.GetString(1);
                xpv.descripcion = reader.GetString(2);
                xpv.telefono = reader.GetString(3);
                xpv.direccion = reader.GetString(4);
            }
            xcon.con.Close();
            return xpv;
        }
        public void actualizar_proveedor(clsProveedor xpv) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "proveedor_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@proveedor", xpv.id);
            xcon.cmd.Parameters.AddWithValue("@nombre", xpv.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xpv.descripcion);
            xcon.cmd.Parameters.AddWithValue("@telefono", xpv.telefono);
            xcon.cmd.Parameters.AddWithValue("@direccion", xpv.direccion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_proveedor(clsProveedor xpv) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "proveedor_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@proveedor", xpv.id);
            xcon.exec_command();
            xcon.con.Close();
        }
    }
}
