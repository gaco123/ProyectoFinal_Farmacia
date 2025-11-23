using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsCliente {
        public int id { get; set; }
        public string nombre { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public clsCliente() { }
        public clsCliente(int id, string nombre, string ape_paterno, string ape_materno, string telefono, string direccion) {
            this.id = id;
            this.nombre = nombre;
            this.ape_paterno = ape_paterno;
            this.ape_materno = ape_materno;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
