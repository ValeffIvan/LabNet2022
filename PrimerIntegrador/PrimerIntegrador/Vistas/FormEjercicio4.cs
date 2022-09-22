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
using PrimerIntegrador.Controles;

namespace PrimerIntegrador.Vistas
{
    public partial class FormEjercicio4 : Form
    {
        LogicEj4 logicEj4 = new LogicEj4();
        public FormEjercicio4()
        {
            InitializeComponent();
        }

        private void btn_verexcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                throw logicEj4.TirarExcepcion();
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
