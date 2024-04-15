using Datos.BD;
using Datos.Entidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace IPRESENTATIOS
{
    public partial class IPRENTA : Form
    {
        private readonly RentaDeVideosContext _context;
        public IPRENTA()
        {
            InitializeComponent();
            _context = new RentaDeVideosContext();
        }

        private void IPRENTA_Load(object sender, EventArgs e)
        {
            CargarRentasEnDataGridView();
            CargarClientesEnComboBox();
            CargarPeliculasEnComboBox();
            CBPeliculaId.SelectedIndexChanged += CBPeliculaId_SelectedIndexChanged;

            CBPeliculaId.SelectedIndex = 0; 
            CBPeliculaId_SelectedIndexChanged(null, null);
            TxtCantidad.Text = "1"; 
            CalcularTotal(); 
            BtnRentar.Click += BtnRentar_Click;
        }

        private void CargarClientesEnComboBox()
        {
            var clientes = _context.Clientes
                .Select(c => new
                {
                    ClienteId = c.ClienteId,
                    NombreCompleto = c.ClienteId + " - " + c.Nombre + " " + c.Apellidos
                })
                .ToList();

            CBClienteId.DataSource = clientes;
            CBClienteId.DisplayMember = "NombreCompleto"; // Mostrar el nombre completo del cliente
            CBClienteId.ValueMember = "ClienteId";        // Valor real del ID del cliente
        }

        private void CargarPeliculasEnComboBox()
        {
            var peliculas = _context.Peliculas
                .Select(p => new
                {
                    PeliculaId = p.PeliculaId,
                    NombrePelicula = p.PeliculaId + " - " + p.Nombre,
                    PrecioRenta = p.PrecioRenta
                })
                .ToList();

            CBPeliculaId.DataSource = peliculas;
            CBPeliculaId.DisplayMember = "NombrePelicula"; // Mostrar el nombre de la película
            CBPeliculaId.ValueMember = "PeliculaId";        // Valor real del ID de la película
        }

        private void CargarRentasEnDataGridView()
        {
            var rentas = _context.Rentas
                .Select(r => new
                {
                    r.RentaId,
                    ClienteId = r.ClienteId,
                    NombreApellidoCliente = r.Cliente.Nombre + " " + r.Cliente.Apellidos,
                    PeliculaId = r.PeliculaId,
                    NombrePelicula = r.Pelicula.Nombre,
                    r.FechaRenta,
                    r.FechaRetorno,
                    r.Cantidad,
                    r.PrecioRenta
                })
                .ToList();

            DGVRenta.DataSource = rentas;
        }


        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CBPeliculaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CBPeliculaId.SelectedValue?.ToString(), out int peliculaId))
            {
                var pelicula = _context.Peliculas.FirstOrDefault(p => p.PeliculaId == peliculaId);
                if (pelicula != null)
                {
                    TxtPrecio.Text = pelicula.PrecioRenta.ToString(); // Mostrar el precio de la película
                    CalcularTotal();
                }
            }
        }

        private void CalcularTotal()
        {
            if (int.TryParse(TxtCantidad.Text, out int cantidad) && decimal.TryParse(TxtPrecio.Text, out decimal precio))
            {
                decimal total = cantidad * precio;
                LblTotal.Text = total.ToString();
            }
            else
            {
                LblTotal.Text = ""; // Limpiar el total si la cantidad o el precio no son válidos
            }
        }

        private void BtnRentar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CBClienteId.SelectedValue?.ToString(), out int clienteId) &&
                int.TryParse(CBPeliculaId.SelectedValue?.ToString(), out int peliculaId) &&
                int.TryParse(TxtCantidad.Text, out int cantidad) &&
                decimal.TryParse(TxtPrecio.Text, out decimal precio) &&
                decimal.TryParse(LblTotal.Text, out decimal total))
            {
                var confirmResult = MessageBox.Show("¿Desea confirmar la renta?", "Confirmar Renta", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Crear una nueva renta
                        Renta renta = new Renta
                        {
                            ClienteId = clienteId,
                            PeliculaId = peliculaId,
                            FechaRenta = DateTime.Now,
                            FechaRetorno = DateTime.Now.AddDays(5),
                            Cantidad = cantidad,
                            PrecioRenta = precio,
                        };

                        // Agregar la renta a la base de datos
                        _context.Rentas.Add(renta);
                        _context.SaveChanges();

                        MessageBox.Show("Renta realizada correctamente");

                        // Limpiar los controles después de guardar
                        TxtCantidad.Text = "1";
                        TxtPrecio.Text = "";
                        LblTotal.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la renta: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente");
            }
        }




    }
}
