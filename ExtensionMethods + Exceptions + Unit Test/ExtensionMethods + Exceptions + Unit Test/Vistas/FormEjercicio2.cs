using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods___Exceptions___Unit_Test.Controles;
using ExtensionMethods___Exceptions___Unit_Test.Excepciones;

namespace ExtensionMethods___Exceptions___Unit_Test.Vistas
{
    public partial class FormEjercicio2 : Form
    {
        ControlEjercicio2 control = new ControlEjercicio2();
        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (nupd_numero1.Value >= 0 && nupd_numero2.Value >= 0)
                {
                    MessageBox.Show(control.Dividir(nupd_numero1.Value, nupd_numero2.Value));
                }
                else
                {
                    throw new NumeroInvalidoException ();
                }
            }
            catch (NumeroInvalidoException nex)
            {
                MessageBox.Show(nex.Message);
            }

        }
    }
}
