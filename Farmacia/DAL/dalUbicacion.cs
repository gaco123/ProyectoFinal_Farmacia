using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class dalUbicacion {
        public void insertar_ubicacion(clsUbicacion xubi) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ubicacion_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@zona", xubi.zona);
            cmd.Parameters.AddWithValue("@estante", xubi.estante);
            cmd.Parameters.AddWithValue("@nivel", xubi.nivel);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsUbicacion seleccionar_ubicacion(int ubicacion) {
            clsUbicacion xubi = new clsUbicacion();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ubicacion_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xubi.id = reader.GetInt32(0);
                xubi.zona = reader.GetString(1);
                xubi.estante = reader.GetInt32(2);
                xubi.nivel = reader.GetInt32(3);
            }
            con.Close();
            return xubi;
        }
        public void actualizar_ubicacion(clsUbicacion xubi) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ubicacion_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ubicacion", xubi.id);
            cmd.Parameters.AddWithValue("@zona", xubi.zona);
            cmd.Parameters.AddWithValue("@estante", xubi.estante);
            cmd.Parameters.AddWithValue("@nivel", xubi.nivel);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_ubicacion(clsUbicacion xubi) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ubicacion_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ubicacion", xubi.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
