using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerIntegrador.Controles;
using PrimerIntegrador.Excepciones;
using PrimerIntegrador.Metodos_extendidos;

namespace PrimerIntegrador.Vistas
{
    public partial class FormEjercicio2 : Form
    {
        Ejercicio2Control control = new Ejercicio2Control();
        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(control.Dividir(txt_num1.Text, txt_num2.Text));
        }
    }
}
