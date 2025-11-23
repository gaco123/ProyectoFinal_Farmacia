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
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "laboratorio_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", xlab.nombre);
            cmd.Parameters.AddWithValue("@direccion", xlab.direccion);
            cmd.Parameters.AddWithValue("@telefono", xlab.telefono);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsLaboratorio seleccionar_laboratorio(int laboratorio) {
            clsLaboratorio xlab = new clsLaboratorio();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "laboratorio_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@laboratorio", laboratorio);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xlab.id = reader.GetInt32(0);
                xlab.nombre = reader.GetString(1);
                xlab.direccion = reader.GetString(2);
                xlab.telefono = reader.GetString(3);
            }
            con.Close();
            return xlab;
        }
        public void actualizar_laboratorio(clsLaboratorio xlab) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "laboratorio_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@laboratorio", xlab.id);
            cmd.Parameters.AddWithValue("@nombre", xlab.nombre);
            cmd.Parameters.AddWithValue("@direccion", xlab.direccion);
            cmd.Parameters.AddWithValue("@telefono", xlab.telefono);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_laboratorio(clsLaboratorio xlab) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "laboratorio_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@laboratorio", xlab.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
