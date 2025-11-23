using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DAL {
    public class dalProducto {
        public void insetar_producto(clsProducto xpro) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "producto_insert";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", xpro.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xpro.descripcion);
            cmd.Parameters.AddWithValue("@principio_activo", xpro.principio_activo);
            cmd.Parameters.AddWithValue("@laboratorio", xpro.laboratorio);
            cmd.Parameters.AddWithValue("@categoria", xpro.categoria);
            cmd.Parameters.AddWithValue("@concentracion", xpro.concentracion);
            cmd.Parameters.AddWithValue("@unidad_medida", xpro.unidad_medida);
            cmd.Parameters.AddWithValue("@presentacion", xpro.presentacion);
            cmd.Parameters.AddWithValue("@stock_actual", xpro.stock_actual);
            cmd.Parameters.AddWithValue("@stock_minimo", xpro.stock_minimo);
            cmd.Parameters.AddWithValue("@stock_maximo", xpro.stock_maximo);
            cmd.Parameters.AddWithValue("@ubicacion", xpro.ubicacion);
            cmd.Parameters.AddWithValue("@precio_unitario", xpro.precio_unitario);
            cmd.Parameters.AddWithValue("@costo_unitario", xpro.costo_unitario);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsProducto seleccionar_producto(int producto) {
            clsProducto xpro = new clsProducto();
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "registrostock_select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", producto);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                xpro.id = reader.GetInt32(0);
                xpro.nombre = reader.GetString(1);
                xpro.descripcion = reader.GetString(2);
                xpro.principio_activo = reader.GetString(3);
                xpro.laboratorio = reader.GetInt32(4);
                xpro.categoria = reader.GetInt32(5);
                xpro.concentracion = reader.GetInt32(6);
                xpro.unidad_medida = reader.GetString(7);
                xpro.presentacion = reader.GetString(8);
                xpro.stock_actual = reader.GetInt32(9);
                xpro.stock_maximo = reader.GetInt32(10);
                xpro.stock_minimo = reader.GetInt32(11);
                xpro.ubicacion = reader.GetInt32(12);
                xpro.precio_unitario = reader.GetDouble(13);
                xpro.costo_unitario = reader.GetDouble(14);
                xpro.estado = reader.GetString(15);
            }
            con.Close();
            return xpro;
        }
        public void actualizar_producto(clsProducto xpro) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "producto_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", xpro.id);
            cmd.Parameters.AddWithValue("@nombre", xpro.nombre);
            cmd.Parameters.AddWithValue("@descripcion", xpro.descripcion);
            cmd.Parameters.AddWithValue("@principio_activo", xpro.principio_activo);
            cmd.Parameters.AddWithValue("@laboratorio", xpro.laboratorio);
            cmd.Parameters.AddWithValue("@categoria", xpro.categoria);
            cmd.Parameters.AddWithValue("@concentracion", xpro.concentracion);
            cmd.Parameters.AddWithValue("@unidad_medida", xpro.unidad_medida);
            cmd.Parameters.AddWithValue("@presentacion", xpro.presentacion);
            cmd.Parameters.AddWithValue("@stock_actual", xpro.stock_actual);
            cmd.Parameters.AddWithValue("@stock_minimo", xpro.stock_minimo);
            cmd.Parameters.AddWithValue("@stock_maximo", xpro.stock_maximo);
            cmd.Parameters.AddWithValue("@ubicacion", xpro.ubicacion);
            cmd.Parameters.AddWithValue("@precio_unitario", xpro.precio_unitario);
            cmd.Parameters.AddWithValue("@costo_unitario", xpro.costo_unitario);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar_producto(clsProducto xpro) {
            SqlConnection con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "producto_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", xpro.id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
