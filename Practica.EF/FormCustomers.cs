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

namespace Practica.EF
{
    public partial class FormCustomers : Form
    {
        CustomersControl customersControl;
        public FormCustomers()
        {
            InitializeComponent();
            customersControl = new CustomersControl();
            dgv_Customers.DataSource = customersControl.GetAll();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(customersControl.AddCustomer(txt_CustomerID.Text, txt_CompanyName.Text,
                                                         txt_ContactName.Text,txt_ContactTitle.Text, 
                                                         txt_Adress.Text, txt_City.Text, txt_Region.Text,
                                                         txt_PostalCode.Text, txt_Country.Text,
                                                         txt_Phone.Text, txt_Fax.Text));
            dgv_Customers.DataSource = null;
            dgv_Customers.DataSource = customersControl.GetAll();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CustomerID.Text = "";
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
            MessageBox.Show(customersControl.Delete(dgv_Customers.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void dgv_Customers_Click(object sender, EventArgs e)
        {
            Customers customers = customersControl.GetCustomer(dgv_Customers.SelectedRows[0].Cells[0].Value.ToString());
            txt_CustomerID.Text = customers.CustomerID;
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
