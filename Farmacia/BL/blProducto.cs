using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blProducto {
        public void agregar_producto(clsProducto xpro) {
            dalProducto xdp = new dalProducto();
            xdp.insetar_producto(xpro);
        }
        public clsProducto leer_producto(int producto) {
            dalProducto xdp = new dalProducto();
            return xdp.seleccionar_producto(producto);
        }
        public void actualizar_producto(clsProducto xpro) {
            dalProducto xdp = new dalProducto();
            xdp.actualizar_producto(xpro);
        }
        public void eliminar_producto(clsProducto xpro) {
            dalProducto xdp = new dalProducto();
            xdp.eliminar_producto(xpro);
        }
        public int contar_producto() {
            dalProducto xdp = new dalProducto();
            return xdp.contar_producto();
        }
    }
}
