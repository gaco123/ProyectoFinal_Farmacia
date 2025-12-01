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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "usuario_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@rol", xusr.rol);
            xcon.cmd.Parameters.AddWithValue("@username", xusr.username);
            xcon.cmd.Parameters.AddWithValue("@contrasena", xusr.contrasena);
            xcon.cmd.Parameters.AddWithValue("@nombre", xusr.nombre);
            xcon.cmd.Parameters.AddWithValue("@ape_paterno", xusr.ape_paterno);
            xcon.cmd.Parameters.AddWithValue("@ape_materno", xusr.ape_materno);
            xcon.cmd.Parameters.AddWithValue("@telefono", xusr.telefono);
            xcon.cmd.Parameters.AddWithValue("@email", xusr.email);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsUsuario seleccionar_usuario(int usuario) {
            clsUsuario xusr = new clsUsuario();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "usuario_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@usuario", usuario);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
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
            xcon.con.Close();
            return xusr;
        }
        public void actualizar_usuario(clsUsuario xusr) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "usuario_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@usuario", xusr.id);
            xcon.cmd.Parameters.AddWithValue("@rol", xusr.rol);
            xcon.cmd.Parameters.AddWithValue("@username", xusr.username);
            xcon.cmd.Parameters.AddWithValue("@contrasena", xusr.contrasena);
            xcon.cmd.Parameters.AddWithValue("@nombre", xusr.nombre);
            xcon.cmd.Parameters.AddWithValue("@ape_paterno", xusr.ape_paterno);
            xcon.cmd.Parameters.AddWithValue("@ape_materno", xusr.ape_materno);
            xcon.cmd.Parameters.AddWithValue("@telefono", xusr.telefono);
            xcon.cmd.Parameters.AddWithValue("@email", xusr.email);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_usuario(clsUsuario xusr) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "usuario_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@usuario", xusr.id);
            xcon.exec_command();
            xcon.con.Close();
        }
    }
}
