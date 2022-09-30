using Practica.EF.Logic.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Linq.UI
{
    public partial class FormData : Form
    {
        LinqControl linqControl = new LinqControl();
        public FormData()
        {
            InitializeComponent();
        }

        private void cb_ejercicios_TextUpdate(object sender, EventArgs e)
        {
            if (cb_ejercicios.Text== "Ejercicio 1")
            {
                var oneCustomer = linqControl.GetCustomers();
                dgv_ejercicios.DataSource= oneCustomer.First();
                
            }
        }
    }
}
