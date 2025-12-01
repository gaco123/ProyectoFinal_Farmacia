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
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "producto_insert";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@nombre", xpro.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xpro.descripcion);
            xcon.cmd.Parameters.AddWithValue("@principio_activo", xpro.principio_activo);
            xcon.cmd.Parameters.AddWithValue("@laboratorio", xpro.laboratorio);
            xcon.cmd.Parameters.AddWithValue("@categoria", xpro.categoria);
            xcon.cmd.Parameters.AddWithValue("@concentracion", xpro.concentracion);
            xcon.cmd.Parameters.AddWithValue("@unidad_medida", xpro.unidad_medida);
            xcon.cmd.Parameters.AddWithValue("@presentacion", xpro.presentacion);
            xcon.cmd.Parameters.AddWithValue("@stock_actual", xpro.stock_actual);
            xcon.cmd.Parameters.AddWithValue("@stock_minimo", xpro.stock_minimo);
            xcon.cmd.Parameters.AddWithValue("@stock_maximo", xpro.stock_maximo);
            xcon.cmd.Parameters.AddWithValue("@ubicacion", xpro.ubicacion);
            xcon.cmd.Parameters.AddWithValue("@precio_unitario", xpro.precio_unitario);
            xcon.cmd.Parameters.AddWithValue("@costo_unitario", xpro.costo_unitario);
            xcon.exec_command();
            xcon.con.Close();
        }
        public clsProducto seleccionar_producto(int producto) {
            clsProducto xpro = new clsProducto();
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "producto_select";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", producto);
            xcon.con.Open();
            SqlDataReader reader = xcon.cmd.ExecuteReader();
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
            xcon.con.Close();
            return xpro;
        }
        public void actualizar_producto(clsProducto xpro) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "producto_update";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", xpro.id);
            xcon.cmd.Parameters.AddWithValue("@nombre", xpro.nombre);
            xcon.cmd.Parameters.AddWithValue("@descripcion", xpro.descripcion);
            xcon.cmd.Parameters.AddWithValue("@principio_activo", xpro.principio_activo);
            xcon.cmd.Parameters.AddWithValue("@laboratorio", xpro.laboratorio);
            xcon.cmd.Parameters.AddWithValue("@categoria", xpro.categoria);
            xcon.cmd.Parameters.AddWithValue("@concentracion", xpro.concentracion);
            xcon.cmd.Parameters.AddWithValue("@unidad_medida", xpro.unidad_medida);
            xcon.cmd.Parameters.AddWithValue("@presentacion", xpro.presentacion);
            xcon.cmd.Parameters.AddWithValue("@stock_actual", xpro.stock_actual);
            xcon.cmd.Parameters.AddWithValue("@stock_minimo", xpro.stock_minimo);
            xcon.cmd.Parameters.AddWithValue("@stock_maximo", xpro.stock_maximo);
            xcon.cmd.Parameters.AddWithValue("@ubicacion", xpro.ubicacion);
            xcon.cmd.Parameters.AddWithValue("@precio_unitario", xpro.precio_unitario);
            xcon.cmd.Parameters.AddWithValue("@costo_unitario", xpro.costo_unitario);
            xcon.exec_command();
            xcon.con.Close();
        }
        public void eliminar_producto(clsProducto xpro) {
            SQLCon xcon = new SQLCon();
            xcon.cmd.CommandText = "producto_delete";
            xcon.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            xcon.cmd.Parameters.AddWithValue("@producto", xpro.id);
            xcon.exec_command();
            xcon.con.Close();
        }
    }
}
