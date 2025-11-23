using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blLaboratorio {
        public void agregar_laboratorio(clsLaboratorio xlab) {
            dalLaboratorio xdl = new dalLaboratorio();
            xdl.insertar_laboratorio(xlab);
        }
        public clsLaboratorio leer_laboratorio(int laboratorio) {
            dalLaboratorio xdl = new dalLaboratorio();
            return xdl.seleccionar_laboratorio(laboratorio);
        }
        public void actualizar_laboratorio(clsLaboratorio xlab) {
            dalLaboratorio xdl = new dalLaboratorio();
            xdl.actualizar_laboratorio(xlab);
        }
        public void eliminar_laboratorio(clsLaboratorio xlab) {
            dalLaboratorio xdl = new dalLaboratorio();
            xdl.eliminar_laboratorio(xlab);
        }
    }
}