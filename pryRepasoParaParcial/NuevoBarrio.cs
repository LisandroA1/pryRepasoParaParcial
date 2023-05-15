using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRepasoParaParcial
{
    public partial class NuevoBarrio : Form
    {
        public NuevoBarrio()
        {
            InitializeComponent();
        }
        clsBarrios barrio = new clsBarrios();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                barrio.Barrio = Convert.ToInt32(txtCodigo.Text);
                barrio.Nombre = txtNombre.Text;

                barrio.grabar();

                if (barrio.Barrio == 0)
                {
                    MessageBox.Show("Barrio repetido, no se pudo grabar", "ERROR");
                }
                else
                {
                    MessageBox.Show("BARRIO GUARDADO CON EXITO", "ERROR");
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
