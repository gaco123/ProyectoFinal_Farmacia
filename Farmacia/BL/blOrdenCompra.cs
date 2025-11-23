using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blOrdenCompra {
        public void agregar_ordencompra(clsOrdenCompra xodc) {
            dalOrdenCompra xdoc = new dalOrdenCompra();
            xdoc.insertar_ordencompra(xodc);
        }
        public clsOrdenCompra leer_ordencompra(int orden) {
            dalOrdenCompra xdoc = new dalOrdenCompra();
            return xdoc.seleccionar_ordencompra(orden);
        }
        public void actualizar_ordenventa(clsOrdenCompra xodc) {
            dalOrdenCompra xdoc = new dalOrdenCompra();
            xdoc.actualizar_ordencompra(xodc);
        }
        public void eliminar_ordencompra(clsOrdenCompra xodc) {
            dalOrdenCompra xdoc = new dalOrdenCompra();
            xdoc.eliminar_ordencompra(xodc);
        }
    }
}
