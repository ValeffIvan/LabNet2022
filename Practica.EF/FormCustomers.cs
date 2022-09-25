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

namespace Practica.EF
{
    public partial class FormCustomers : Form
    {
        CustomersLogic customersLogic;
        public FormCustomers()
        {
            InitializeComponent();
            customersLogic = new CustomersLogic();
            dgv_Customers.DataSource = customersLogic.GetAll();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
