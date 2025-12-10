using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blUbicacion {
        public void agregar_ubicacion(clsUbicacion xubi) {
            dalUbicacion xdu = new dalUbicacion();
            xdu.insertar_ubicacion(xubi);
        }
        public clsUbicacion leer_ubicacion(int ubicacion) {
            dalUbicacion xdu = new dalUbicacion();
            return xdu.seleccionar_ubicacion(ubicacion);
        }
        public void actualizar_ubicacion(clsUbicacion xubi) {
            dalUbicacion xdu = new dalUbicacion();
            xdu.actualizar_ubicacion(xubi);
        }
        public void eliminar_ubicacion(clsUbicacion xubi) {
            dalUbicacion xdu = new dalUbicacion();
            xdu.eliminar_ubicacion(xubi);
        }
        public int contar_ubicacion() {
            dalUbicacion xdu = new dalUbicacion();
            return xdu.contar_ubicacion();
        }
    }
}
