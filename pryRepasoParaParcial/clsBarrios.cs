using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Threading;

namespace pryRepasoParaParcial
{
    internal class clsBarrios
    {
        private string cadena = "";
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int barrio;
        private string nombre;

        public int Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public clsBarrios()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Barrios";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[1];
            vector[0] = tabla.Columns["barrio"];
            tabla.PrimaryKey = vector;


        }

        public DataTable GetAll()
        {
            return tabla;
        }

        public void grabar()
        {
            DataRow filaBusca = tabla.Rows.Find(barrio);

            if (filaBusca is null)
            {
                DataRow fila = tabla.NewRow();
                fila["barrio"] = barrio;
                fila["nombre"] = nombre;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                barrio = 0;
                nombre = "";
            }
        }

        public string buscar(int barrio)
        {
            DataRow fila = tabla.Rows.Find(barrio);
            return fila["nombre"].ToString();
        }
    }
}
