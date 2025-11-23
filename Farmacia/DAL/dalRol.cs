using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalRol {
        public void insertar_rol(clsRol xrl) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", xrl.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xrl.descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsRol seleccionar_rol(int rol) {
            clsRol xrl = new clsRol();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rol", rol);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xrl.id = reader.GetInt32(0);
                xrl.nombre = reader.GetString(1);
                xrl.descripcion = reader.GetString(2);
            }
            con.Close();
            return xrl;
        }
        public void actualizar_rol(clsRol xrl) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rol", xrl.id);
            cmd.Parameters.AddWithValue("@nombre", xrl.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xrl.descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_rol(clsRol xrl) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rol", xrl.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
