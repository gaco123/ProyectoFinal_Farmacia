using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsCategoria {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public clsCategoria() { }
        public clsCategoria(int id, string nome, string descripcion) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public string Datos() {
            return $"ID: {id}\nNombre: {nombre}\nDescripcion: {descripcion}";
        }
    }
}
