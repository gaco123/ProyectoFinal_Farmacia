using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DAL {
    public class dalCategoria {
        public void insertar_categoria(clsCategoria xcal){
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "categoria_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", xcal.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xcal.descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsCategoria seleccionar_categoria(int categoria) {
            clsCategoria xcal = new clsCategoria();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "categoria_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoria", categoria);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xcal.id = reader.GetInt32(0);
                xcal.nombre = reader.GetString(1);
                xcal.descripcion = reader.GetString(2);
            }
            con.Close();
            return xcal;
        }
        public void actualizar_categoria(clsCategoria xcal) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "categoria_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoria", xcal.id);
            cmd.Parameters.AddWithValue("@nombre", xcal.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xcal.descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_categoria(clsCategoria xcal) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "categoria_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoria", xcal.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
