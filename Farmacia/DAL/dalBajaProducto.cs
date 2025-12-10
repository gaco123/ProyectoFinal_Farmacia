using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalBajaProducto {
        public void insertar_bajaproducto(clsBajaProducto xbpr) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "bajaproducto_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", xbpr.producto);
            xcon.cmd.Parameters.AddWithValue("@fecha_baja", xbpr.fecha_baja);
            xcon.cmd.Parameters.AddWithValue("@motivo", xbpr.motivo);
            xcon.cmd.Parameters.AddWithValue("@usuario", xbpr.usuario);
            xcon.cmd.Parameters.AddWithValue("@observaciones", xbpr.observaciones);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsBajaProducto seleccionar_bajaproducto(int producto) {
            clsBajaProducto xbpr = new clsBajaProducto();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "bajaproducto_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", producto);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xbpr.producto = reader.GetInt32(0);
                xbpr.fecha_baja = reader.GetDateTime(1);
                xbpr.motivo = reader.GetString(2);
                xbpr.usuario = reader.GetInt32(3);
                xbpr.observaciones = reader.GetString(4);
            }
            xcon.con.Close();
            return xbpr;
        }
        public void actualizar_bajaproducto(clsBajaProducto xbpr) { 
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "bajaproducto_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", xbpr.producto);
            xcon.cmd.Parameters.AddWithValue("@fecha_baja", xbpr.fecha_baja);
            xcon.cmd.Parameters.AddWithValue("@motivo", xbpr.motivo);
            xcon.cmd.Parameters.AddWithValue("@usuario", xbpr.usuario);
            xcon.cmd.Parameters.AddWithValue("@observaciones", xbpr.observaciones);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_bajaproducto(clsBajaProducto xbpr) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "bajaproducto_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", xbpr.producto);
            xcon.exec_command();
            xcon.con.Close();
        }
        public int contar_bajaproducto() {
            SQLCon xcon = new SQLCon();
            int numfilas = 0;
            xcon.con.Open();
            xcon.cmd.CommandText = "bajaproducto_count";
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
