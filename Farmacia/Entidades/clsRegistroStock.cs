using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsRegistroStock {
        public int id { get; set; }
        public int producto { get; set; }
        public int orden_compra { get; set; }
        public int orden_venta { get; set; }
        public DateTime fecha_registro { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public int stock_es { get; set; }
        public int usuario { get; set; }
        public string observacion { get; set; }
        public double precio_unitario { get; set; }
        public double costo_unitario { get; set; }
        public clsRegistroStock() { }
        public clsRegistroStock(int id, int producto, int orden_compra, int orden_venta, DateTime fecha_registro, DateTime fecha_vencimiento, int stock_es, int usuario, string observacion, double precio_unitario, double costo_unitario) {
            this.id = id;
            this.producto = producto;
            this.orden_compra = orden_compra;
            this.orden_venta = orden_venta;
            this.fecha_registro = fecha_registro;
            this.fecha_vencimiento = fecha_vencimiento;
            this.stock_es = stock_es;
            this.usuario = usuario;
            this.observacion = observacion;
            this.precio_unitario = precio_unitario;
            this.costo_unitario = costo_unitario;
        }
    }
}
