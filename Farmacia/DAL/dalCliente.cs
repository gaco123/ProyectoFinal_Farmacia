using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL {
    public class dalCliente {
        public void insertar_cliente(clsCliente xcl) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "cliente_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@nombre", xcl.nombre);
            xcon.cmd.Parameters.AddWithValue("@ape_paterno", xcl.ape_paterno);
            xcon.cmd.Parameters.AddWithValue("@ape_materno", xcl.ape_materno);
            xcon.cmd.Parameters.AddWithValue("@telefono", xcl.telefono);
            xcon.cmd.Parameters.AddWithValue("@direccion", xcl.direccion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsCliente seleccionar_cliente(int cliente) {
            clsCliente xcl = new clsCliente();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "cliente_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@cliente", cliente);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xcl.id = reader.GetInt32(0);
                xcl.nombre = reader.GetString(1);
                xcl.ape_paterno = reader.GetString(2);
                xcl.ape_materno = reader.GetString(3);
                xcl.telefono = reader.GetString(4);
                xcl.direccion = reader.GetString(5);
            }
            xcon.con.Close();
            return xcl;
        }
        public void actualizar_cliente(clsCliente xcl) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "cliente_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@cliente", xcl.id);
            xcon.cmd.Parameters.AddWithValue("@nombre", xcl.nombre);
            xcon.cmd.Parameters.AddWithValue("@ape_paterno", xcl.ape_paterno);
            xcon.cmd.Parameters.AddWithValue("@ape_materno", xcl.ape_materno);
            xcon.cmd.Parameters.AddWithValue("@telefono", xcl.telefono);
            xcon.cmd.Parameters.AddWithValue("@direccion", xcl.direccion);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_cliente(clsCliente xcl) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "cliente_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@cliente", xcl.id);
            xcon.exec_command();
            xcon.con.Close();
        }
    }
}
