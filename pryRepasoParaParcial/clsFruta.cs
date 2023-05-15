using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace pryRepasoParaParcial
{
     class clsFruta
    {
        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int fruta;
        private string nombre;

        public int Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public clsFruta()
        {
            cadena = clsConexion.getCadena();
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Frutas";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[1];
            vector[0] = tabla.Columns["fruta"];
            tabla.PrimaryKey = vector;
        }

        public DataTable GetAll()
        {
            return tabla;
        }

        public void Grabar() //GRABAR EN BASE DE DATOS
        {

            DataRow filaBusca = tabla.Rows.Find(fruta);

            if (filaBusca is null)
            {
                DataRow fila = tabla.NewRow();
                fila["fruta"] = fruta;
                fila["nombre"] = nombre;
                
                tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                fruta = 0;
                nombre = "";
                
            }
        }

        public void VerTodasLasFrutas(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgv.Rows.Add(fila["fruta"], fila["nombre"]);
            }
        }

        public string Buscar(int fruta)
        {
            DataRow fila = tabla.Rows.Find(fruta);
            return fila["nombre"].ToString();
        }
    }
}
