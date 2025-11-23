using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalOrdenCompra {
        public void insertar_ordencompra(clsOrdenCompra xodc) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordencompra_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha_orden", xodc.fecha_orden);
            cmd.Parameters.AddWithValue("@proveedor", xodc.proveedor);
            cmd.Parameters.AddWithValue("@costo_total", xodc.costo_total);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsOrdenCompra seleccionar_ordencompra(int orden) {
            clsOrdenCompra xodv = new clsOrdenCompra();
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
                xodv.proveedor = reader.GetInt32(2);
                xodv.costo_total = reader.GetDouble(3);
            }
            con.Close();
            return xodv;
        }
        public void actualizar_ordencompra(clsOrdenCompra xodc) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordencompra_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", xodc.id);
            cmd.Parameters.AddWithValue("@fecha_orden", xodc.fecha_orden);
            cmd.Parameters.AddWithValue("@cliente", xodc.proveedor);
            cmd.Parameters.AddWithValue("@costo_total", xodc.costo_total);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_ordencompra(clsOrdenCompra xodc) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ordencompra_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", xodc.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
