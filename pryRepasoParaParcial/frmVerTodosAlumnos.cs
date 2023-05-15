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
    public partial class frmVerTodosAlumnos : Form
    {
        public frmVerTodosAlumnos()
        {
            InitializeComponent();
        }
        clsAlumnos Alumnos;
        private void frmVerTodosAlumnos_Load(object sender, EventArgs e)
        {
            Alumnos = new clsAlumnos();
            Alumnos.verTodosAlumnos(dgvAlumnos);
        }
    }
}
