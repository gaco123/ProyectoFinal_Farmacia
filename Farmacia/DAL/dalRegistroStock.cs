using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalRegistroStock {
        public void insertar_registrostock(clsRegistroStock xrst) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "registrostock_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", xrst.producto);
            cmd.Parameters.AddWithValue("@orden_compra", xrst.orden_compra);
            cmd.Parameters.AddWithValue("@orden_venta", xrst.orden_venta);
            cmd.Parameters.AddWithValue("@fecha_registro", xrst.fecha_registro);
            cmd.Parameters.AddWithValue("@fecha_vencimiento", xrst.fecha_vencimiento);
            cmd.Parameters.AddWithValue("@stock_es", xrst.stock_es);
            cmd.Parameters.AddWithValue("@observacion", xrst.observacion);
            cmd.Parameters.AddWithValue("@precio_unitario", xrst.precio_unitario);
            cmd.Parameters.AddWithValue("@costo_unitario", xrst.costo_unitario);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsRegistroStock seleccionar_registrostock(int regstock) {
            clsRegistroStock xrst = new clsRegistroStock();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "registrostock_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@regstock", regstock);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xrst.id = reader.GetInt32(0);
                xrst.producto = reader.GetInt32(1);
                xrst.orden_compra = reader.GetInt32(2);
                xrst.orden_venta = reader.GetInt32(3);
                xrst.fecha_registro = reader.GetDateTime(4);
                xrst.fecha_vencimiento = reader.GetDateTime(5);
                xrst.stock_es = reader.GetInt32(6);
                xrst.usuario = reader.GetInt32(7);
                xrst.observacion = reader.GetString(8);
                xrst.precio_unitario = reader.GetDouble(9);
                xrst.costo_unitario = reader.GetDouble(10);
            }
            con.Close();
            return xrst;
        }
        public void actualizar_registrostock(clsRegistroStock xrst) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "registrostock_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@registro", xrst.id);
            cmd.Parameters.AddWithValue("@producto", xrst.producto);
            cmd.Parameters.AddWithValue("@orden_compra", xrst.orden_compra);
            cmd.Parameters.AddWithValue("@orden_venta", xrst.orden_venta);
            cmd.Parameters.AddWithValue("@fecha_registro", xrst.fecha_registro);
            cmd.Parameters.AddWithValue("@fecha_vencimiento", xrst.fecha_vencimiento);
            cmd.Parameters.AddWithValue("@stock_es", xrst.stock_es);
            cmd.Parameters.AddWithValue("@observacion", xrst.observacion);
            cmd.Parameters.AddWithValue("@precio_unitario", xrst.precio_unitario);
            cmd.Parameters.AddWithValue("@costo_unitario", xrst.costo_unitario);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_registrostock(clsRegistroStock xrst) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "registrostock_eliminar";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@registro", xrst.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
