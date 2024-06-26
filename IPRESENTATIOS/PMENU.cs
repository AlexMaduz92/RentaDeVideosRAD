﻿using Datos.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPRESENTATIOS
{
    public partial class PMENU : Form
    {
        public PMENU()
        {
            InitializeComponent();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPelicula peliculaForm = new IPelicula();
            peliculaForm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICliente clienteaForm = new ICliente();
            clienteaForm.Show();
        }

        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPRENTA rentaForm = new IPRENTA();
            rentaForm.Show();
        }
    }
}
