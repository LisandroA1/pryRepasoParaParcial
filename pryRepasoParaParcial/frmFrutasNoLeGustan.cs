﻿using System;
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
    public partial class frmFrutasNoLeGustan : Form
    {
        public frmFrutasNoLeGustan()
        {
            InitializeComponent();
        }
        clsAlumnos Alumnos;
        clsLeGustan NoLegustan;
        //private void btnVer_Click(object sender, EventArgs e)
        //{
        //    NoLegustan = new clsLeGustan();

        //    int dni = Convert.ToInt32(cbAlumno.SelectedValue);

        //    NoLegustan.NoLeGustan(dgvFruta, dni);
        //}

        private void frmFrutasNoLeGustan_Load(object sender, EventArgs e)
        {
            Alumnos = new clsAlumnos();
            cbAlumno.DisplayMember = "nombre";
            cbAlumno.ValueMember = "dni";
            cbAlumno.DataSource = Alumnos.getAlumnos();
        }
    }
}
