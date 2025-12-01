using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalLaboratorio {
        public void insertar_laboratorio(clsLaboratorio xlab) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "laboratorio_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@nombre", xlab.nombre);
            xcon.cmd.Parameters.AddWithValue("@direccion", xlab.direccion);
            xcon.cmd.Parameters.AddWithValue("@telefono", xlab.telefono);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsLaboratorio seleccionar_laboratorio(int laboratorio) {
            clsLaboratorio xlab = new clsLaboratorio();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "laboratorio_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@laboratorio", laboratorio);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xlab.id = reader.GetInt32(0);
                xlab.nombre = reader.GetString(1);
                xlab.direccion = reader.GetString(2);
                xlab.telefono = reader.GetString(3);
            }
            xcon.con.Close();
            return xlab;
        }
        public void actualizar_laboratorio(clsLaboratorio xlab) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "laboratorio_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@laboratorio", xlab.id);
            xcon.cmd.Parameters.AddWithValue("@nombre", xlab.nombre);
            xcon.cmd.Parameters.AddWithValue("@direccion", xlab.direccion);
            xcon.cmd.Parameters.AddWithValue("@telefono", xlab.telefono);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_laboratorio(clsLaboratorio xlab) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "laboratorio_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@laboratorio", xlab.id);
            xcon.exec_command();
            xcon.con.Close();
        }
    }
}
