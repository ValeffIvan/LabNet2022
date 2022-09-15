using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_POO.Controles;

namespace Ejercicio_POO
{
    public partial class Form1 : Form
    {
        Control_Vehiculos control = new Control_Vehiculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(control.agregar(cb_tipodetransporte.Text, (int)nupd_cantidadpasajeros.Value));
            cargarlista();
        }
        private void cargarlista()
        {
            lb_transportes.DataSource = null;
            lb_transportes.DataSource = control.listar();
        }

        private void cb_tipodetransporte_TextChanged(object sender, EventArgs e)
        {
            if (cb_tipodetransporte.Text == "Omnibus")
            {
                nupd_cantidadpasajeros.Maximum = 100;
            }
            else if (cb_tipodetransporte.Text == "Taxi")
            {
                nupd_cantidadpasajeros.Maximum = 4;
            }
        }
    }
}
