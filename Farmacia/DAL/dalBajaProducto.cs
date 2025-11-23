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
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "bajaproducto_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", xbpr.producto);
            cmd.Parameters.AddWithValue("@fecha_baja", xbpr.fecha_baja);
            cmd.Parameters.AddWithValue("@motivo", xbpr.motivo);
            cmd.Parameters.AddWithValue("@usuario", xbpr.usuario);
            cmd.Parameters.AddWithValue("@observaciones", xbpr.observaciones);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsBajaProducto seleccionar_bajaproducto(int producto) {
            clsBajaProducto xbpr = new clsBajaProducto();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "bajaproducto_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", producto);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xbpr.producto = reader.GetInt32(1);
                xbpr.fecha_baja = reader.GetDateTime(2);
                xbpr.motivo = reader.GetString(3);
                xbpr.usuario = reader.GetInt32(4);
                xbpr.observaciones = reader.GetString(5);
            }
            con.Close();
            return xbpr;
        }
        public void actualizar_bajaproducto(clsBajaProducto xbpr) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "bajaproducto_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", xbpr.producto);
            cmd.Parameters.AddWithValue("@fecha_baja", xbpr.fecha_baja);
            cmd.Parameters.AddWithValue("@motivo", xbpr.motivo);
            cmd.Parameters.AddWithValue("@usuario", xbpr.usuario);
            cmd.Parameters.AddWithValue("@observaciones", xbpr.observaciones);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_bajaproducto(clsBajaProducto xbpr) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "bajaproducto_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", xbpr.producto);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
