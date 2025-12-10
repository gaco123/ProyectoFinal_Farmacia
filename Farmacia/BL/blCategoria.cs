using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blCategoria {
        public void agregar_categoria(clsCategoria xcat) {
            dalCategoria xdc = new dalCategoria();
            xdc.insertar_categoria(xcat);
        }
        public clsCategoria leer_categoria(int categoria) {
            dalCategoria xdc = new dalCategoria();
            return xdc.seleccionar_categoria(categoria);
        }
        public void actualizar_categoria(clsCategoria xcat) {
            dalCategoria xdc = new dalCategoria();
            xdc.actualizar_categoria(xcat);
        }
        public void eliminar_categoria(clsCategoria xcat) {
            dalCategoria xdc = new dalCategoria();
            xdc.eliminar_categoria(xcat);
        }
        public int contar_categoria() {
            dalCategoria xdc = new dalCategoria();
            return xdc.contar_categoria();
        }
    }
}
