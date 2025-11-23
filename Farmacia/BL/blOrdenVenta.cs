using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blOrdenVenta {
        public void agregar_ordenventa(clsOrdenVenta xodv) {
            dalOrdenVenta xdov= new dalOrdenVenta();
            xdov.insertar_ordenventa(xodv);
        }
        public clsOrdenVenta leer_ordenventa(int orden) {
            dalOrdenVenta xdov = new dalOrdenVenta();
            return xdov.seleccionar_ordenventa(orden);
        }
        public void actualizar_ordenventa(clsOrdenVenta xodv) {
            dalOrdenVenta xdov = new dalOrdenVenta();
            xdov.actualizar_ordenventa(xodv);
        }
        public void eliminar_ordenventa(clsOrdenVenta xodv) {
            dalOrdenVenta xdov = new dalOrdenVenta();
            xdov.eliminar_ordenventa(xodv);
        }
    }
}