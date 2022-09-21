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
            MessageBox.Show(logic.Message+"\n"+logic.ToString());
        }
    }
}
