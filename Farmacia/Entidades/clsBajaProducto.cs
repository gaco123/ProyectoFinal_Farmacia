using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsBajaProducto {
        public int producto { get; set; }
        public DateTime fecha_baja { get; set; }
        public string motivo { get; set; }
        public int usuario { get; set; }
        public string observaciones { get; set; }
        public clsBajaProducto() { }
        public clsBajaProducto(int producto, DateTime fecha_baja, string motivo, int usuario, string observaciones) {
            this.producto = producto;
            this.fecha_baja = fecha_baja;
            this.motivo = motivo;
            this.usuario = usuario;
            this.observaciones = observaciones;
        }
        public string Datos() {
            return $"ID: {producto}\nFecha Baja: {fecha_baja}\nMotivo: {motivo}\nUsuario: {usuario}\nObservaciones: {observaciones}";
        }
    }
}
