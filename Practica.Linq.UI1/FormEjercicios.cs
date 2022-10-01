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
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetCustomers().ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 2")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetProductsWithoutStock().ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 3")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetProductsWithStock3Units().ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 4")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetCustomersRegionWA().ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 5")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetElementOrNull().ToList();
            }
            else if (cb_ejercicios.Text == "Ejercicio 6. Mayuscula")
            {
                try
                {
                    var item = linqControl.GetCustomersName().ToList();
                    item.ForEach(c =>
                    {
                        c.ContactName = c.ContactName.ToUpper();
                    });
                    dgv_ejercicios.DataSource = null;
                    dgv_ejercicios.DataSource = item.ToList();
                    dgv_ejercicios.Columns[11].Visible = false;
                    dgv_ejercicios.Columns[12].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
            else if (cb_ejercicios.Text == "Ejercicio 6. Minuscula")
            {
                try
                {
                    var item = linqControl.GetCustomersName().ToList();
                    var updatedItems = item.Select(p => new Customers
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
                    }).ToList();
                    dgv_ejercicios.DataSource = null;
                    dgv_ejercicios.DataSource = updatedItems.ToList();
                    dgv_ejercicios.Columns[11].Visible = false;
                    dgv_ejercicios.Columns[12].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos");
                }
            }
            else if (cb_ejercicios.Text == "Ejercicio 7")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetJoinCustomersAndOrders().ToList();
                dgv_ejercicios.Columns[16].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 8")
            {
                var top3 = linqControl.GetFirst3CustomersRegionWA().Take(3);
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = top3.ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 9")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetProductOrderByName().ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 10")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetProductOrderByUnitInStock().ToList();
                dgv_ejercicios.Columns[12].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 11")
            {
                dgv_ejercicios.DataSource = linqControl.GetProductsWithCategory().ToList();
                dgv_ejercicios.Columns[2].Visible = false;
                dgv_ejercicios.Columns[4].Visible = false;
                dgv_ejercicios.Columns[5].Visible = false;
                dgv_ejercicios.Columns[6].Visible = false;
                dgv_ejercicios.Columns[7].Visible = false;
                dgv_ejercicios.Columns[8].Visible = false;
                dgv_ejercicios.Columns[9].Visible = false;
                dgv_ejercicios.Columns[10].Visible = false;
                dgv_ejercicios.Columns[11].Visible = false;
                dgv_ejercicios.Columns[12].Visible = false;
            }
            else if (cb_ejercicios.Text == "Ejercicio 12")
            {
                dgv_ejercicios.DataSource = null;
                dgv_ejercicios.DataSource = linqControl.GetFirstElementProducts().Take(1).ToList();
                dgv_ejercicios.Columns[11].Visible = false;
                dgv_ejercicios.Columns[12].Visible = false;
            }

        }
    }
}
