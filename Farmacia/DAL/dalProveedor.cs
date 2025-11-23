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
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "proveedor_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", xpv.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xpv.descripcion);
            cmd.Parameters.AddWithValue("@telefono", xpv.telefono);
            cmd.Parameters.AddWithValue("@direccion", xpv.direccion);
        }
        public clsProveedor seleccionar_proveedor(int proveedor) {
            clsProveedor xpv = new clsProveedor();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "proveedor_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proveedor", proveedor);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xpv.id = reader.GetInt32(0);
                xpv.nombre = reader.GetString(1);
                xpv.descripcion = reader.GetString(2);
                xpv.telefono = reader.GetString(3);
                xpv.direccion = reader.GetString(4);
            }
            con.Close();
            return xpv;
        }
        public void actualizar_proveedor(clsProveedor xpv) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "proveedor_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proveedor", xpv.id);
            cmd.Parameters.AddWithValue("@nombre", xpv.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xpv.descripcion);
            cmd.Parameters.AddWithValue("@telefono", xpv.telefono);
            cmd.Parameters.AddWithValue("@direccion", xpv.direccion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_proveedor(clsProveedor xpv) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "proveedor_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@proveedor", xpv.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
