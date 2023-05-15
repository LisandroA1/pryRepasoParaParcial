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
    public partial class NuevoAlumno : Form
    {
        public NuevoAlumno()
        {
            InitializeComponent();
        }
        clsBarrios Barrio;
        clsAlumnos Alumno;
        private void Form1_Load(object sender, EventArgs e)
        {
            //CARGAR LISTA
            try
            {
                Barrio = new clsBarrios();
                
                
                lstBarrio.DisplayMember = "nombre";
                lstBarrio.ValueMember = "barrio";
                lstBarrio.DataSource = Barrio.GetAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error con la base de datos");
                this.Close();
            }
        }

        //Registrar Dato
        private void cmdGrabar_Click(object sender, EventArgs e)
        {

                Alumno = new clsAlumnos();
                

                Alumno.Dni = Convert.ToInt32(txtDni.Text);
                Alumno.Nombre = txtNombre.Text;

                if (optFemenino.Checked)
                {
                    Alumno.Sexo = "F";
                }
                else
                {
                    Alumno.Sexo = "M";
                }


                Alumno.Barrio = Convert.ToInt32(lstBarrio.SelectedValue); 

                Alumno.Grabar();

                if (Alumno.Dni == 0)
                {
                    MessageBox.Show("ALUMNO REPETIDO, NO SE PUDO GRABAR", "ERROR");
                }
                else
                {
                    MessageBox.Show("ALUMNO GUARDADO CON EXITO");
                    txtDni.Text = "";
                    txtNombre.Text = "";
                    txtDni.Focus();
                }


            
            
        }
    }
}
