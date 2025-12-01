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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ubicacion_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@zona", xubi.zona);
            xcon.cmd.Parameters.AddWithValue("@estante", xubi.estante);
            xcon.cmd.Parameters.AddWithValue("@nivel", xubi.nivel);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsUbicacion seleccionar_ubicacion(int ubicacion) {
            clsUbicacion xubi = new clsUbicacion();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ubicacion_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
            while (reader.Read()) {
                xubi.id = reader.GetInt32(0);
                xubi.zona = reader.GetString(1);
                xubi.estante = reader.GetInt32(2);
                xubi.nivel = reader.GetInt32(3);
            }
            xcon.con.Close();
            return xubi;
        }
        public void actualizar_ubicacion(clsUbicacion xubi) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ubicacion_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@ubicacion", xubi.id);
            xcon.cmd.Parameters.AddWithValue("@zona", xubi.zona);
            xcon.cmd.Parameters.AddWithValue("@estante", xubi.estante);
            xcon.cmd.Parameters.AddWithValue("@nivel", xubi.nivel);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_ubicacion(clsUbicacion xubi) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "ubicacion_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@ubicacion", xubi.id);
            xcon.exec_command();
            xcon.con.Close();
        }
    }
}
