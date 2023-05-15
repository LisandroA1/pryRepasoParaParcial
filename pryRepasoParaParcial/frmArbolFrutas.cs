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
    public partial class frmArbolFrutas : Form
    {
        public frmArbolFrutas()
        {
            InitializeComponent();
        }

        private void frmArbolFrutas_Load(object sender, EventArgs e)
        {
            //Declaro Nodos en el load
            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;

            clsAlumnos objAlumnos = new clsAlumnos();
            clsFruta objFruta = new clsFruta();
            clsLeGustan objLeGustan = new clsLeGustan();

            //Declarar nodo raiz en el TreeView y adjuntarle el icono correspondiente
            abuelo = treeView1.Nodes.Add("Frutas");

            DataTable tFruta = objFruta.GetAll();
            DataTable tAlumno = objAlumnos.getAlumnos();
            DataTable tLeGustan = objLeGustan.GetAll();

            //foreach (DataRow fFruta in tFruta.Rows)
            //{
            //    padre = abuelo.Nodes.Add(fFruta["nombre"].ToString());
            //    foreach (DataRow fAlumnos in tLegustan.Rows)
            //    {
            //        if (fAlumnos["fruta"].ToString() == fFruta["fruta"].ToString())
            //        {
            //            foreach (DataRow drAlumnos in tAlumno.Rows)
            //            {
            //                if (fAlumnos["dni"].ToString() == drAlumnos["dni"].ToString())
            //                {
            //                    hijo = padre.Nodes.Add(drAlumnos["nombre"].ToString());
            //                }
            //            }
            //        }
            //    }
            //}

            foreach (DataRow Ffruta in tFruta.Rows)
            {
                padre = abuelo.Nodes.Add(Ffruta["nombre"].ToString());
                foreach (DataRow Falumnos in tLeGustan.Rows)
                {
                    if (Falumnos["fruta"].ToString() == Ffruta["fruta"].ToString())
                    {
                        foreach (DataRow drAlumnos in tAlumno.Rows)
                        {
                            if (Falumnos["dni"].ToString() == drAlumnos["dni"].ToString())
                            {
                                hijo = padre.Nodes.Add(drAlumnos["nombre"].ToString());
                            }
                        }
                    }

                }
            }



        }
    }
}
