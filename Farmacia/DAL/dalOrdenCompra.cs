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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordencompra_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@fecha_orden", xodc.fecha_orden);
            xcon.cmd.Parameters.AddWithValue("@proveedor", xodc.proveedor);
            xcon.cmd.Parameters.AddWithValue("@costo_total", xodc.costo_total);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsOrdenCompra seleccionar_ordencompra(int orden) {
            clsOrdenCompra xodv = new clsOrdenCompra();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordenventa_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", orden);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xodv.id = reader.GetInt32(0);
                xodv.fecha_orden = reader.GetDateTime(1);
                xodv.proveedor = reader.GetInt32(2);
                xodv.costo_total = reader.GetDouble(3);
            }
            xcon.con.Close();
            return xodv;
        }
        public void actualizar_ordencompra(clsOrdenCompra xodc) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordencompra_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", xodc.id);
            xcon.cmd.Parameters.AddWithValue("@fecha_orden", xodc.fecha_orden);
            xcon.cmd.Parameters.AddWithValue("@cliente", xodc.proveedor);
            xcon.cmd.Parameters.AddWithValue("@costo_total", xodc.costo_total);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_ordencompra(clsOrdenCompra xodc) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ordencompra_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@orden", xodc.id);
            xcon.exec_command();
            xcon.con.Close();
        }
        public int contar_ordencompra() {
            SQLCon xcon = new SQLCon();
            int numfilas = 0;
            xcon.con.Open();
            xcon.cmd.CommandText = "ordencompra_count";
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
