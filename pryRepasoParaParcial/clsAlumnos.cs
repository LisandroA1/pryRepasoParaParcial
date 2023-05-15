using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace pryRepasoParaParcial
{
    internal class clsAlumnos
    {
        clsBarrios b = new clsBarrios();

        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        

        private int dni;
        private string nombre;
        private string sexo;
        private Int32 barrio;
        private string foto;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public Int32 Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public clsAlumnos()
        {
            try
            {
                cadena = clsConexion.getCadena();
                conector = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conector;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Alumnos";

                adaptador = new OleDbDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);

                DataColumn[] vector = new DataColumn[1];
                vector[0] = tabla.Columns["dni"];
                tabla.PrimaryKey = vector;
            }
            catch (Exception)
            {

                MessageBox.Show("NO se pudo");
            }

            
            
        }
        public DataTable getAlumnos()
        {
            return tabla;
        }

        public void Grabar() //GRABAR EN BASE DE DATOS
        {
            
            DataRow filaBusca = tabla.Rows.Find(dni);

            if (filaBusca is null)
            {
                DataRow fila = tabla.NewRow();
                fila["dni"] = dni;
                fila["nombre"] = nombre;
                fila["sexo"] = sexo;
                fila["barrio"] = barrio;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                dni = 0;
                nombre = "";
                sexo = "";
                barrio = 0;
            }
        }

        public void buscar()
        {
            DataRow fila = tabla.Rows.Find(dni);

            if (fila == null)
            {
                nombre = "";
             
            }
            else
            {
                nombre = fila["nombre"].ToString();
                sexo = fila["sexo"].ToString();
                foto = fila["foto"].ToString();
               
            }
        }

        public string buscar(int dni)
        {
            DataRow fila = tabla.Rows.Find(dni);
            return fila["nombre"].ToString();
            
        }

        public void ver(DataGridView dgv, string busco)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                string sexo = "FEMENINO";

                if (fila["sexo"].ToString() == "M")
                {
                    sexo = "MASCULINO";
                }

                string nb = b.buscar(Convert.ToInt32(fila["barrio"]));

                int pos = fila["nombre"].ToString().IndexOf(busco);

                if (pos > -1)
                {
                    dgv.Rows.Add(fila["dni"], fila["nombre"], sexo, nb);
                }
            }
        }

        public void verTodosAlumnos(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                string sexo = "FEMENINO";

                if (fila["sexo"].ToString() == "M")
                {
                    sexo = "MASCULINO";
                }

                string nb = b.buscar(Convert.ToInt32(fila["barrio"]));

                dgv.Rows.Add(fila["dni"], fila["nombre"], sexo, nb);
            }
        }
    }
}
