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
    public partial class frmVerTodasLasFrutas : Form
    {
        public frmVerTodasLasFrutas()
        {
            InitializeComponent();
        }
        clsFruta Fruta;
        private void frmVerTodasLasFrutas_Load(object sender, EventArgs e)
        {
            Fruta = new clsFruta();
            Fruta.VerTodasLasFrutas(dgvFruta);
        }
    }
}
