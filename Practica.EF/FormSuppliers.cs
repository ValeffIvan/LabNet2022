using Practica.EF.Entities;
using Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.EF.UI
{
    public partial class FormSuppliers : Form
    {
        SuppliersLogic suppliersLogic;
        public FormSuppliers()
        {
            InitializeComponent();
            suppliersLogic = new SuppliersLogic();
            dgv_Suppliers.DataSource = suppliersLogic.GetAll();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
