using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsProducto {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string principio_activo { get; set; }
        public int laboratorio { get; set; }
        public int categoria { get; set; }
        public int concentracion { get; set; }
        public string unidad_medida { get; set; }
        public string presentacion { get; set; }
        public int stock_actual { get; set; }
        public int stock_minimo { get; set; }
        public int stock_maximo { get; set; }
        public int ubicacion { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal costo_unitario { get; set; }
        public string estado { get; set; }

        public clsProducto() { }
        public clsProducto(int id, string nombre, string descripcion, string principio_activo, int laboratorio, int categoria, int concentracion, string unidad_medida, string presentacion, int stock_actual, int stock_minimo, int stock_maximo, int ubicacion, decimal precio_unitario, decimal costo_unitario, string estado) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.principio_activo = principio_activo;
            this.laboratorio = laboratorio;
            this.categoria = categoria;
            this.concentracion = concentracion;
            this.unidad_medida = unidad_medida;
            this.presentacion = presentacion;
            this.stock_actual = stock_actual;
            this.stock_minimo = stock_minimo;
            this.stock_maximo = stock_maximo;
            this.ubicacion = ubicacion;
            this.precio_unitario = precio_unitario;
            this.costo_unitario = costo_unitario;
            this.estado = estado;
        }
    }
}