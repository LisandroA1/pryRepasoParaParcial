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
    public partial class frmAgregarOQuitarFrutaQueLeGustaAAlumno : Form
    {
        public frmAgregarOQuitarFrutaQueLeGustaAAlumno()
        {
            InitializeComponent();
        }
        clsAlumnos Alumnos;
        clsFruta Fruta;
        clsLeGustan Legustan;
        private void frmAgregarOQuitarFrutaQueLeGustaAAlumno_Load(object sender, EventArgs e)
        {
            //Cargo lista

            Alumnos = new clsAlumnos();
            Fruta = new clsFruta();

            cbFruta.DisplayMember = "nombre";
            cbFruta.ValueMember = "fruta";
            cbFruta.DataSource = Fruta.GetAll();

            cbAlumno.DisplayMember = "nombre";
            cbAlumno.ValueMember = "dni";
            cbAlumno.DataSource = Alumnos.getAlumnos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Legustan = new clsLeGustan();
            Legustan.Dni = Convert.ToInt32(cbAlumno.SelectedValue);
            Legustan.Fruta = Convert.ToInt32(cbFruta.SelectedValue);

            Legustan.Agregar();
            MessageBox.Show("Agregado con exito");
        }
    }
}
