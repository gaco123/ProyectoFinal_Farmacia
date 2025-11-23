using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalUsuario {
        public void insertar_usuario(clsUsuario xusr) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "usuario_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rol", xusr.rol);
            cmd.Parameters.AddWithValue("@username", xusr.username);
            cmd.Parameters.AddWithValue("@contrasena", xusr.contrasena);
            cmd.Parameters.AddWithValue("@nombre", xusr.nombre);
            cmd.Parameters.AddWithValue("@ape_paterno", xusr.ape_paterno);
            cmd.Parameters.AddWithValue("@ape_materno", xusr.ape_materno);
            cmd.Parameters.AddWithValue("@telefono", xusr.telefono);
            cmd.Parameters.AddWithValue("@email", xusr.email);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsUsuario seleccionar_usuario(int usuario) {
            clsUsuario xusr = new clsUsuario();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "usuario_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xusr.id = reader.GetInt32(0);
                xusr.rol = reader.GetInt32(1);
                xusr.username = reader.GetString(2);
                xusr.contrasena = reader.GetString(3);
                xusr.nombre = reader.GetString(4);
                xusr.ape_paterno = reader.GetString(5);
                xusr.ape_materno = reader.GetString(6);
                xusr.telefono = reader.GetString(7);
                xusr.email = reader.GetString(8);
            }
            con.Close();
            return xusr;
        }
        public void actualizar_usuario(clsUsuario xusr) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "usuario_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", xusr.id);
            cmd.Parameters.AddWithValue("@rol", xusr.rol);
            cmd.Parameters.AddWithValue("@username", xusr.username);
            cmd.Parameters.AddWithValue("@contrasena", xusr.contrasena);
            cmd.Parameters.AddWithValue("@nombre", xusr.nombre);
            cmd.Parameters.AddWithValue("@ape_paterno", xusr.ape_paterno);
            cmd.Parameters.AddWithValue("@ape_materno", xusr.ape_materno);
            cmd.Parameters.AddWithValue("@telefono", xusr.telefono);
            cmd.Parameters.AddWithValue("@email", xusr.email);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_usuario(clsUsuario xusr) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "usuario_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", xusr.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
