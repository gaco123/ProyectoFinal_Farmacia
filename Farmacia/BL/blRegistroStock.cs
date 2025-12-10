using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blRegistroStock {
        public void agregar_registrostock(clsRegistroStock xrst) {
            dalRegistroStock xdrs = new dalRegistroStock();
            xdrs.insertar_registrostock(xrst);
        }
        public clsRegistroStock leer_registrostock(int regstock) {
            dalRegistroStock xdrs = new dalRegistroStock();
            return xdrs.seleccionar_registrostock(regstock);
        }
        public void actualizar_registrostock(clsRegistroStock xrst) {
            dalRegistroStock xdrs = new dalRegistroStock();
            xdrs.actualizar_registrostock(xrst);
        }
        public void eliminar_registrostock(clsRegistroStock xrst) {
            dalRegistroStock xdrs = new dalRegistroStock();
            xdrs.eliminar_registrostock(xrst);
        }
        public int contar_registrostock() {
            dalRegistroStock xdrs = new dalRegistroStock();
            return xdrs.contar_registrostock();
        }
    }
}
