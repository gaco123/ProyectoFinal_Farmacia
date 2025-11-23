using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsRol {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public clsRol() { }
        public clsRol(int id, string nombre, string descripcion) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
