using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace pryRepasoParaParcial
{
    internal class clsLeGustan
    {
        clsFruta f = new clsFruta();

        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int dni;
        private int fruta;

        public int Dni
        {
            get{ return dni; }
            set{ dni = value; }
        }

        public int Fruta
        {
            get{ return fruta; }
            set{ fruta = value; }
        }

        public clsLeGustan()
        {
            cadena = clsConexion.getCadena();
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "LeGustan";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }

        public DataTable GetAll()
        {
            return tabla;
        }

        public void Agregar()
        {
            DataRow fila = tabla.NewRow();
            fila["dni"] = dni;
            fila["fruta"] = fruta;
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }

        public void LeGustan(DataGridView FrutasLeGustan, int buscar)
        {
            FrutasLeGustan.Rows.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                if (buscar == Convert.ToInt32(fila["dni"]))
                {
                    string fruta = f.Buscar(Convert.ToInt32(fila["fruta"]));
                    FrutasLeGustan.Rows.Add(fruta);
                }
            }
        }

        //public void NoLeGustan(DataGridView FrutasNoLeGustan, int buscar)
        //{
        //    FrutasNoLeGustan.Rows.Clear();

        //    foreach (DataRow fila in tabla.Rows)
        //    {
        //        if (buscar == Convert.ToInt32(fila["dni"]))
        //        {
        //            string fruta = f.Buscar(Convert.ToInt32(fila["fruta"]));
        //            FrutasNoLeGustan.Rows.Add(fruta);
        //        }
        //    }
        //}

        public void VerTodo(DataGridView dgv)
        {

        }
    }
}
