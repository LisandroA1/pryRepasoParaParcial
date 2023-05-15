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
    public partial class frmConsultaAlumnoPorParteDeSuNombre : Form
    {
        public frmConsultaAlumnoPorParteDeSuNombre()
        {
            InitializeComponent();
        }
        clsAlumnos alumnos;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            alumnos.ver(dgvAlumno, txtNombre.Text);
        }

        private void frmConsultaAlumnoPorParteDeSuNombre_Load(object sender, EventArgs e)
        {
            alumnos = new clsAlumnos();
        }
    }
}
