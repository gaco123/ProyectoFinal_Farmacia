using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalCliente {
        public void insertar_cliente(clsCliente xcl) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "cliente_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", xcl.nombre);
            cmd.Parameters.AddWithValue("@ape_paterno", xcl.ape_paterno);
            cmd.Parameters.AddWithValue("@ape_materno", xcl.ape_materno);
            cmd.Parameters.AddWithValue("@telefono", xcl.telefono);
            cmd.Parameters.AddWithValue("@direccion", xcl.direccion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsCliente seleccionar_cliente(int cliente) {
            clsCliente xcl = new clsCliente();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "cliente_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", cliente);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xcl.id = reader.GetInt32(0);
                xcl.nombre = reader.GetString(1);
                xcl.ape_paterno = reader.GetString(2);
                xcl.ape_materno = reader.GetString(3);
                xcl.telefono = reader.GetString(4);
                xcl.direccion = reader.GetString(5);
            }
            con.Close();
            return xcl;
        }
        public void actualizar_cliente(clsCliente xcl) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "cliente_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", xcl.id);
            cmd.Parameters.AddWithValue("@nombre", xcl.nombre);
            cmd.Parameters.AddWithValue("@ape_paterno", xcl.ape_paterno);
            cmd.Parameters.AddWithValue("@ape_materno", xcl.ape_materno);
            cmd.Parameters.AddWithValue("@telefono", xcl.telefono);
            cmd.Parameters.AddWithValue("@direccion", xcl.direccion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_cliente(clsCliente xcl) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "cliente_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", xcl.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
