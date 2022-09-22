using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerIntegrador.Excepciones;

namespace PrimerIntegrador.Vistas
{
    public partial class FormEjercicio3 : Form
    {
        Logic logic = new Logic();
        public FormEjercicio3()
        {
            InitializeComponent();
        }

        private void btn_verexcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                throw logic.TirarExcepcion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mensaje: {ex.Message} \n tipo:{ex}" );
            }
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
