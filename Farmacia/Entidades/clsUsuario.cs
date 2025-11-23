using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class clsUsuario {
        public int id { get; set; }
        public int rol { get; set; }
        public string username { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public clsUsuario() { }
        public clsUsuario(int id, int rol, string username, string contrasena, string nombre, string ape_paterno, string ape_materno, string telefono, string email) {
            this.id = id;
            this.rol = rol;
            this.username = username;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.ape_paterno = ape_paterno;
            this.ape_materno = ape_materno;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
