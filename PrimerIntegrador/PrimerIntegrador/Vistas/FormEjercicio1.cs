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

namespace PrimerIntegrador.Vistas
{
    public partial class FormEjercicio1 : Form
    {
        Ejercicio1Control control = new Ejercicio1Control();
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(control.Dividir(nupd_valorunico.Value));
        }
    }
}
