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
    public partial class frmConsultaAlumnoPorDni : Form
    {
        public frmConsultaAlumnoPorDni()
        {
            InitializeComponent();
        }
        clsAlumnos Alumnos = new clsAlumnos();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumnos.Dni = Convert.ToInt32(txtDni.Text);
            Alumnos.buscar();
            txtNombre.Text = Alumnos.Nombre;
            txtSexo.Text = Alumnos.Sexo;

            if (Alumnos.Nombre == "")
            {
                pbFoto.Image = null;
            }
            else
            {
                pbFoto.Load("fotos/" + Alumnos.Foto);
            }

            if (Alumnos.Nombre == "")
            {
                MessageBox.Show("Alumno no encontrado", "SIN DATOS");
            }
        }

        private void frmConsultaAlumnoPorDni_Load(object sender, EventArgs e)
        {

        }
    }
}
