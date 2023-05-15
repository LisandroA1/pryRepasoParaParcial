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
    public partial class frmFrutasLeGustan : Form
    {
        public frmFrutasLeGustan()
        {
            InitializeComponent();
        }
        clsAlumnos Alumnos;
        clsLeGustan Legustan;
        private void frmFrutasLeGustan_Load(object sender, EventArgs e)
        {
            Alumnos = new clsAlumnos();
            cbAlumno.DisplayMember = "nombre";
            cbAlumno.ValueMember = "dni";
            cbAlumno.DataSource = Alumnos.getAlumnos();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Legustan = new clsLeGustan();

            int dni = Convert.ToInt32(cbAlumno.SelectedValue);
            Legustan.LeGustan(dgvFrutas, dni);
        }
    }
}
