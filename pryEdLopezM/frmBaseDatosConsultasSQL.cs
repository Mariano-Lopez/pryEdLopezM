﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    public partial class frmBaseDatosConsultasSQL : Form
    {
        public frmBaseDatosConsultasSQL()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BBDD = new clsBaseDeDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            BBDD.Listar(dgvBBDD, txtConsulta.Text);


        }
    }
}
