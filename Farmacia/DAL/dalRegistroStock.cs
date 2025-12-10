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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "registrostock_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", xrst.producto);
            xcon.cmd.Parameters.AddWithValue("@orden_compra", xrst.orden_compra);
            xcon.cmd.Parameters.AddWithValue("@orden_venta", xrst.orden_venta);
            xcon.cmd.Parameters.AddWithValue("@fecha_registro", xrst.fecha_registro);
            xcon.cmd.Parameters.AddWithValue("@fecha_vencimiento", xrst.fecha_vencimiento);
            xcon.cmd.Parameters.AddWithValue("@stock_es", xrst.stock_es);
            xcon.cmd.Parameters.AddWithValue("@observacion", xrst.observacion);
            xcon.cmd.Parameters.AddWithValue("@precio_unitario", xrst.precio_unitario);
            xcon.cmd.Parameters.AddWithValue("@costo_unitario", xrst.costo_unitario);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsRegistroStock seleccionar_registrostock(int regstock) {
            clsRegistroStock xrst = new clsRegistroStock();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "registrostock_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@regstock", regstock);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
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
            xcon.con.Close();
            return xrst;
        }
        public void actualizar_registrostock(clsRegistroStock xrst) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "registrostock_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@registro", xrst.id);
            xcon.cmd.Parameters.AddWithValue("@producto", xrst.producto);
            xcon.cmd.Parameters.AddWithValue("@orden_compra", xrst.orden_compra);
            xcon.cmd.Parameters.AddWithValue("@orden_venta", xrst.orden_venta);
            xcon.cmd.Parameters.AddWithValue("@fecha_registro", xrst.fecha_registro);
            xcon.cmd.Parameters.AddWithValue("@fecha_vencimiento", xrst.fecha_vencimiento);
            xcon.cmd.Parameters.AddWithValue("@stock_es", xrst.stock_es);
            xcon.cmd.Parameters.AddWithValue("@observacion", xrst.observacion);
            xcon.cmd.Parameters.AddWithValue("@precio_unitario", xrst.precio_unitario);
            xcon.cmd.Parameters.AddWithValue("@costo_unitario", xrst.costo_unitario);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_registrostock(clsRegistroStock xrst) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "registrostock_eliminar";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@registro", xrst.id);
            xcon.exec_command();
            xcon.con.Close();
        }
        public int contar_registrostock() {
            SQLCon xcon = new SQLCon();
            int numfilas = 0;
            xcon.con.Open();
            xcon.cmd.CommandText = "registrostock_count";
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
