using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalOrdenVenta {
        public void insertar_ordenventa(clsOrdenVenta xodv) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordenventa_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", xodv.id);
            cmd.Parameters.AddWithValue("@fecha_orden", xodv.fecha_orden);
            cmd.Parameters.AddWithValue("@cliente", xodv.cliente);
            cmd.Parameters.AddWithValue("@costo_total", xodv.costo_total);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsOrdenVenta seleccionar_ordenventa(int orden) {
            clsOrdenVenta xodv = new clsOrdenVenta();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordenventa_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", orden);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xodv.id = reader.GetInt32(0);
                xodv.fecha_orden = reader.GetDateTime(1);
                xodv.cliente = reader.GetInt32(2);
                xodv.costo_total = reader.GetDouble(3);
            }
            con.Close();
            return xodv;
        }
        public void actualizar_ordenventa(clsOrdenVenta xodv) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordenventa_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", xodv.id);
            cmd.Parameters.AddWithValue("@fecha_orden", xodv.fecha_orden);
            cmd.Parameters.AddWithValue("@cliente", xodv.cliente);
            cmd.Parameters.AddWithValue("@costo_total", xodv.costo_total);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_ordenventa(clsOrdenVenta xodv) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordenventa_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", xodv.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
