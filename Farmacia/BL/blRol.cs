using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class blRol {
        public void agregar_rol(clsRol xrl) {
            dalRol xdr = new dalRol();
            xdr.insertar_rol(xrl);
        }
        public clsRol leer_rol(int rol) {
            dalRol xdr = new dalRol();
            return xdr.seleccionar_rol(rol);
        }
        public void actualizar_rol(clsRol xrl) {
            dalRol xdr = new dalRol();
            xdr.actualizar_rol(xrl);
        }
        public void eliminar_rol(clsRol xrl) {
            dalRol xdr = new dalRol();
            xdr.eliminar_rol(xrl);
        }
        public int contar_rol() {
            dalRol xdr = new dalRol();
            return xdr.contar_rol();
        }
    }
}
