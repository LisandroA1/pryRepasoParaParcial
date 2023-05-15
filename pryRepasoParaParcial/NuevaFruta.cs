using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRepasoParaParcial
{
    public partial class NuevaFruta : Form
    {
        public NuevaFruta()
        {
            InitializeComponent();
        }
        clsFruta Fruta = new clsFruta();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Fruta.Fruta = Convert.ToInt32(txtCodigo.Text);
                Fruta.Nombre = txtNombre.Text;
                Fruta.Grabar();

                if (Fruta.Fruta == 0)
                {
                    MessageBox.Show("Fruta repetida, no se pudo grabar", "ERROR");
                }
                else
                {
                    MessageBox.Show("FRUTA GUARDADA CON EXITO", "ERROR");
                    txtCodigo.Text = "";
                    txtNombre.Text = "";

                    txtCodigo.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("INGRESE UN NUMERO....", "ERROR");
            }
        }
    }
}
