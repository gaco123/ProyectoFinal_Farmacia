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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "rol_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@nombre", xrl.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xrl.descripcion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsRol seleccionar_rol(int rol) {
            clsRol xrl = new clsRol();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "rol_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@rol", rol);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xrl.id = reader.GetInt32(0);
                xrl.nombre = reader.GetString(1);
                xrl.descripcion = reader.GetString(2);
            }
            xcon.con.Close();
            return xrl;
        }
        public void actualizar_rol(clsRol xrl) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "rol_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@rol", xrl.id);
            xcon.cmd.Parameters.AddWithValue("@nombre", xrl.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xrl.descripcion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_rol(clsRol xrl) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "rol_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@rol", xrl.id);
            xcon.exec_command();
            xcon.con.Close();
        }
        public int contar_rol() {
            SQLCon xcon = new SQLCon();
            int numfilas = 0;
            xcon.con.Open();
            xcon.cmd.CommandText = "rol_count";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                numfilas = reader.GetInt32(0);
            }
            xcon.con.Close();
            return numfilas;
        }
    }
}
