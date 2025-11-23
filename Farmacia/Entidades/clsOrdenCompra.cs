using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsOrdenCompra {
        public int id { get; set; }
        public DateTime fecha_orden { get; set; }
        public int proveedor { get; set; }
        public double costo_total { get; set; }
        public clsOrdenCompra() { }
        public clsOrdenCompra(int id, DateTime fecha_orden, int proveedor, double costo_total) {
            this.id = id;
            this.fecha_orden = fecha_orden;
            this.proveedor = proveedor;
            this.costo_total = costo_total;
        }
    }
}
