using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blProveedor {
        public void agregar_proveedor(clsProveedor xpv) {
            dalProveedor xdpv = new dalProveedor();
            xdpv.insertar_proveedor(xpv);
        }
        public clsProveedor leer_proveedor(int proveedor) {
            dalProveedor xdpv = new dalProveedor();
            return xdpv.seleccionar_proveedor(proveedor);
        }
        public void actualizar_proveedor(clsProveedor xpv) {
            dalProveedor xdpv = new dalProveedor();
            xdpv.actualizar_proveedor(xpv);
        }
        public void eliminar_proveedor(clsProveedor xpv) {
            dalProveedor xdpv = new dalProveedor();
            xdpv.eliminar_proveedor(xpv);
        }
    }
}
