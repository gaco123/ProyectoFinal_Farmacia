using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsOrdenVenta {
        public int id { get; set; }
        public DateTime fecha_orden { get; set; }
        public int cliente { get; set; }
        public double costo_total { get; set; }
        public clsOrdenVenta() { }
        public clsOrdenVenta(int id, DateTime fecha_orden, int cliente, double costo_total) {
            this.id = id;
            this.fecha_orden = fecha_orden;
            this.cliente = cliente;
            this.costo_total = costo_total;
        }
    }
}
