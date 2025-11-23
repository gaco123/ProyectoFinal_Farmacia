using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            blCategoria a = new blCategoria();

            //Insertar una categoria
            /*
            clsCategoria b = new clsCategoria();
            b.id = 1;
            b.nombre = "antifungico";
            b.descripcion = "combate infecciones relacionadas a hongos";
            a.agregar_categoria(b);
            */

            //Leer una categoria
            clsCategoria x = a.leer_categoria(int.Parse(txtTemp.Text));
            lstTemp.Text = x.Datos();
        }
    }
}
