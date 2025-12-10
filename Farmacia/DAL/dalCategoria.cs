using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DAL {
    public class dalCategoria {
        public void insertar_categoria(clsCategoria xcal){
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "categoria_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@nombre", xcal.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xcal.descripcion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsCategoria seleccionar_categoria(int categoria) {
            clsCategoria xcal = new clsCategoria();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "categoria_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@categoria", categoria);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xcal.id = reader.GetInt32(0);
                xcal.nombre = reader.GetString(1);
                xcal.descripcion = reader.GetString(2);
            }
            xcon.con.Close();
            return xcal;
        }
        public void actualizar_categoria(clsCategoria xcal) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "categoria_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@categoria", xcal.id);
            xcon.cmd.Parameters.AddWithValue("@nombre", xcal.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xcal.descripcion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_categoria(clsCategoria xcal) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "categoria_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@categoria", xcal.id);
            xcon.exec_command();
            xcon.con.Close();
        }
        public int contar_categoria() {
            SQLCon xcon = new SQLCon();
            int numfilas = 0;
            xcon.con.Open();
            xcon.cmd.CommandText = "categoria_count";
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
