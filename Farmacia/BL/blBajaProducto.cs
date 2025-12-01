using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blBajaProducto {
        public void agregar_bajaproducto(clsBajaProducto xbpr) {
            dalBajaProducto xdbp = new dalBajaProducto();
            xdbp.insertar_bajaproducto(xbpr);
        }
        public clsBajaProducto leer_bajaproducto(int producto) {
            dalBajaProducto xdbp = new dalBajaProducto();
            return xdbp.seleccionar_bajaproducto(producto);
        }
        public void actualizar_bajaproducto(clsBajaProducto xbpr) {
            dalBajaProducto xdbp = new dalBajaProducto();
            xdbp.actualizar_bajaproducto(xbpr);
        }
        public void eliminar_bajaproducto(clsBajaProducto xbpr) {
            dalBajaProducto xdbp = new dalBajaProducto();
            xdbp.eliminar_bajaproducto(xbpr);
        }
        public int contar_bajaproducto() {
            dalBajaProducto xdbp = new dalBajaProducto();
            return xdbp.contar_bajaproducto();
        }
    }
}
