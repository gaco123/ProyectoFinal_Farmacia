using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsUbicacion {
        public int id { get; set; }
        public string zona { get; set; }
        public int estante { get; set; }
        public int nivel { get; set; }
        public clsUbicacion() { }
        public clsUbicacion(int id, string zona, int estante, int nivel) {
            this.id = id;
            this.zona = zona;
            this.estante = estante;
            this.nivel = nivel;
        }
    }
}
