using Datos.BD;
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
    public partial class IPRENTA : Form
    {
        public IPRENTA()
        {
            InitializeComponent();
        }

        private void IPRENTA_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            CargarRentasEnDataGridView();

        }

        private void CargarRentasEnDataGridView()
        {
            using (var context = new RentaDeVideosContext())
            {
                var rentas = context.Rentas.ToList();
                DGVRenta.DataSource = rentas;
            }
        }

    }
}
