using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blUsuario {
        public void agregar_usuario(clsUsuario xusr) {
            dalUsuario xdur = new dalUsuario();
            xdur.insertar_usuario(xusr);
        }
        public clsUsuario leer_usuario(int usuario) {
            dalUsuario xdur = new dalUsuario();
            return xdur.seleccionar_usuario(usuario);
        }
        public void actualizar_usuario(clsUsuario xusr) {
            dalUsuario xdur = new dalUsuario();
            xdur.actualizar_usuario(xusr);
        }
        public void eliminar_usuario(clsUsuario xusr) {
            dalUsuario xdur = new dalUsuario();
            xdur.eliminar_usuario(xusr);
        }
        public int contar_usuario() {
            dalUsuario xdur = new dalUsuario();
            return xdur.contar_usuario();
        }
    }
}
