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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordenventa_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", xodv.id);
            xcon.cmd.Parameters.AddWithValue("@fecha_orden", xodv.fecha_orden);
            xcon.cmd.Parameters.AddWithValue("@cliente", xodv.cliente);
            xcon.cmd.Parameters.AddWithValue("@costo_total", xodv.costo_total);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsOrdenVenta seleccionar_ordenventa(int orden) {
            clsOrdenVenta xodv = new clsOrdenVenta();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordenventa_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", orden);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xodv.id = reader.GetInt32(0);
                xodv.fecha_orden = reader.GetDateTime(1);
                xodv.cliente = reader.GetInt32(2);
                xodv.costo_total = reader.GetDouble(3);
            }
            xcon.con.Close();
            return xodv;
        }
        public void actualizar_ordenventa(clsOrdenVenta xodv) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordenventa_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", xodv.id);
            xcon.cmd.Parameters.AddWithValue("@fecha_orden", xodv.fecha_orden);
            xcon.cmd.Parameters.AddWithValue("@cliente", xodv.cliente);
            xcon.cmd.Parameters.AddWithValue("@costo_total", xodv.costo_total);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_ordenventa(clsOrdenVenta xodv) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordenventa_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", xodv.id);
            xcon.exec_command();
            xcon.con.Close();
        }
        public int contar_ordenventa() {
            SQLCon xcon = new SQLCon();
            int numfilas = 0;
            xcon.con.Open();
            xcon.cmd.CommandText = "ordenventa_count";
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
