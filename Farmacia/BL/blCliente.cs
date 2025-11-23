using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blCliente {
        public void agregar_cliente(clsCliente xcl) {
            dalCliente xdc = new dalCliente();
            xdc.insertar_cliente(xcl);
        }
        public clsCliente leer_cliente(int cliente) {
            dalCliente xdc = new dalCliente();
            return xdc.seleccionar_cliente(cliente);
        }
        public void actualizar_cliente(clsCliente xcl) {
            dalCliente xdc = new dalCliente();
            xdc.actualizar_cliente(xcl);
        }
        public void eliminar_cliente(clsCliente xcl) {
            dalCliente xdc = new dalCliente();
            xdc.eliminar_cliente(xcl);
        }
    }
}
