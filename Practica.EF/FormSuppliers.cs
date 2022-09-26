using Practica.EF.Entities;
using Practica.EF.Logic;
using Practica.EF.Logic.Control;
using Practica.EF.Logic.Logic;
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
        SuppliersControl suppliersControl;
        public FormSuppliers()
        {
            InitializeComponent();
            suppliersControl = new SuppliersControl();
            dgv_Suppliers.DataSource = suppliersControl.GetAll();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(suppliersControl.AddSuppliers(Convert.ToInt32(npd_SupplierID.Value),
                                                         txt_CompanyName.Text, txt_ContactName.Text,
                                                         txt_ContactTitle.Text, txt_Adress.Text, 
                                                         txt_City.Text, txt_Region.Text,
                                                         txt_PostalCode.Text, txt_Country.Text,
                                                         txt_Phone.Text, txt_Fax.Text));
            dgv_Suppliers.DataSource = null;
            dgv_Suppliers.DataSource= suppliersControl.GetAll();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            npd_SupplierID.Value = 1;
            txt_ContactName.Text = "";
            txt_CompanyName.Text = "";
            txt_Adress.Text = "";
            txt_City.Text = "";
            txt_Region.Text = "";
            txt_Phone.Text = "";
            txt_PostalCode.Text = "";
            txt_Fax.Text = "";
            txt_ContactTitle.Text = "";
            txt_Country.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(suppliersControl.Delete((int)dgv_Suppliers.SelectedRows[0].Cells[0].Value));
        }

        private void dgv_Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers customers = suppliersControl.GetSuppliers((int)dgv_Suppliers.SelectedRows[0].Cells[0].Value);
            npd_SupplierID.Value = customers.SupplierID;
            txt_ContactName.Text = customers.ContactName;
            txt_CompanyName.Text = customers.CompanyName;
            txt_Adress.Text = customers.Address;
            txt_City.Text = customers.City;
            txt_Region.Text = customers.Region;
            txt_Phone.Text = customers.Phone;
            txt_PostalCode.Text = customers.PostalCode;
            txt_Fax.Text = customers.Fax;
            txt_ContactTitle.Text = customers.ContactTitle;
            txt_Country.Text = customers.Country;
        }
    }
}
