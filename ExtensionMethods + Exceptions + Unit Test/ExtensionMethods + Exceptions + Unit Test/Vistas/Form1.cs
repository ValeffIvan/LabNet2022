using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods___Exceptions___Unit_Test.Vistas;

namespace ExtensionMethods___Exceptions___Unit_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejercicio1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 formEjercicio1 = new FormEjercicio1();
            formEjercicio1.Owner = this;
            formEjercicio1.ShowDialog();
        }

        private void btn_ejercicio2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 formEjercicio2 = new FormEjercicio2();
            formEjercicio2.Owner = this;
            formEjercicio2.ShowDialog();
        }

        private void btn_ejercicio3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 formEjercicio3 = new FormEjercicio3();
            formEjercicio3.Owner = this;
            formEjercicio3.ShowDialog();
        }

        private void btn_ejercicio4_Click(object sender, EventArgs e)
        {
            FormEjercicio3 formEjercicio3 = new FormEjercicio3();
            formEjercicio3.Owner = this;
            formEjercicio3.ShowDialog();
        }
    }
}
