using Practica.EF.Entities;
using Practica.EF.Logic.Control;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Linq.UI1
{
    public partial class FormEjercicios : Form
    {
        LinqControl linqControl = new LinqControl();
        public FormEjercicios()
        {
            InitializeComponent();
        }

        private void cb_ejercicios_TextUpdate(object sender, EventArgs e)
        {
            if (cb_ejercicios.Text == "Ejercicio 1")
            {

                //var oneCustomer ;
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetCustomers().ToList().First();
            }
            else if (cb_ejercicios.Text == "Ejercicio 2")
            {
                dgv_ejercicios.DataSource = linqControl.GetProductsWithoutStock().ToList();
            }
            else if (cb_ejercicios.Text == "Ejercicio 3")
            {
                dgv_ejercicios.DataSource = linqControl.GetProductsWithStock3Units().ToList();
            }
            else if (cb_ejercicios.Text == "Ejercicio 4")
            {
                dgv_ejercicios.DataSource = linqControl.GetCustomersRegionWA().ToList();
            }
            else if (cb_ejercicios.Text == "Ejercicio 5")
            {
                dgv_ejercicios.DataSource = linqControl.GetElementOrNull().ToList();
            }
            else if (cb_ejercicios.Text == "Ejercicio 6. Mayuscula")
            {
                var updatedItems = linqControl.GetCustomersName().ToList().Select(p => new Customers
                {
                    CustomerID= p.CustomerID,
                    CompanyName =p.CompanyName,
                    ContactTitle = p.ContactTitle,
                    Address = p.Address,
                    City =p.City,
                    Region = p.Region,
                    PostalCode = p.PostalCode,
                    Country = p.Country,
                    Phone = p.Phone,
                    Fax  = p.Fax,
                    ContactName = p.ContactName.ToUpper(),
                });
                dgv_ejercicios.DataSource = updatedItems.ToList();
                dgv_ejercicios.Columns[11].Visible = false;
                dgv_ejercicios.Columns[12].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 6. Minuscula")
            {
                var updatedItems = linqControl.GetCustomersName().ToList().Select(p => new Customers
                {
                    CustomerID = p.CustomerID,
                    CompanyName = p.CompanyName,
                    ContactTitle = p.ContactTitle,
                    Address = p.Address,
                    City = p.City,
                    Region = p.Region,
                    PostalCode = p.PostalCode,
                    Country = p.Country,
                    Phone = p.Phone,
                    Fax = p.Fax,
                    ContactName = p.ContactName.ToLower(),
                });
                dgv_ejercicios.DataSource = updatedItems.ToList();
                dgv_ejercicios.Columns[11].Visible = false;
                dgv_ejercicios.Columns[12].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 7")
            {
                dgv_ejercicios.DataSource = linqControl.GetJoinCustomersAndOrders().ToList();
                dgv_ejercicios.Columns[16].Visible = false;
            }

        }
    }
}
