using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsProveedor {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public clsProveedor() { }
        public clsProveedor(int id, string nombre, string descripcion, string telefono, string direccion) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
