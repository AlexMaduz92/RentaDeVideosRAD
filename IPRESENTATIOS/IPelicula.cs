using Datos.BD;
using Datos.Entidades;
using Datos.Repositories;
using Datos.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IPRESENTATIOS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PMENU());
        }
    }

    public partial class IPelicula : Form
    {
        private RepositorioPeliculas repositorioPeliculas;

        public IPelicula()
        {
            InitializeComponent();
            var context = new RentaDeVideosContext(); // Crear el contexto de la base de datos
            var repositorio = new Repository<Pelicula>(context);
            repositorioPeliculas = new RepositorioPeliculas(repositorio);
            CargarGeneros(); // Cargar los géneros en el ComboBox
            CargarPeliculasEnDataGridView(); // Cargar las películas en el DataGridView
        }

        private void CargarGeneros()
        {
            // Cargar los géneros en el ComboBox
            CbGenero.Items.AddRange(new string[]
            {
                "Acción", "Animación", "Anime", "Aventura", "Bélico", "Ciencia Ficción",
                "Crimen", "Comedia", "Documental", "Drama", "Fantasía", "Historia",
                "Musical", "Misterio", "Terror", "Suspenso", "Romance"
            });
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                try
                {
                    GuardarPelicula();
                    LimpiarControles();
                    MessageBox.Show("Película guardada correctamente");
                    CargarPeliculasEnDataGridView(); // Volver a cargar las películas en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la película: " + ex.Message);
                }
            }
        }

        private void CargarPeliculasEnDataGridView()
        {
            var peliculas = repositorioPeliculas.ObtenerPeliculas(); // Obtener las películas utilizando el repositorio

            // Asignar la lista de películas al DataSource del DataGridView
            DGVVista.DataSource = peliculas;
        }

        private bool CamposValidos()
        {
            // Validar que los campos obligatorios estén llenos y el género esté seleccionado
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtAutores.Text) ||
                string.IsNullOrWhiteSpace(TxtExsitencia.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecioRenta.Text) ||
                CbGenero.SelectedItem == null)
            {
                MessageBox.Show("Debes completar todos los campos obligatorios para guardar la película");
                return false;
            }

            // Validar que el precio de renta sea un número decimal positivo
            if (!decimal.TryParse(TxtPrecioRenta.Text, out decimal precioRenta) || precioRenta <= 0)
            {
                MessageBox.Show("El precio de renta debe ser un número decimal positivo");
                return false;
            }

            // Validar que la existencia sea un número entero positivo
            if (!int.TryParse(TxtExsitencia.Text, out int existencia) || existencia <= 0)
            {
                MessageBox.Show("La existencia debe ser un número entero positivo");
                return false;
            }

            return true;
        }

        private void GuardarPelicula()
        {
            try
            {
                // Validar la conversión de existencia a int
                if (!int.TryParse(TxtExsitencia.Text, out int existencia))
                {
                    MessageBox.Show("La existencia debe ser un número entero");
                    return;
                }

                // Validar la conversión de precio de renta a decimal
                if (!decimal.TryParse(TxtPrecioRenta.Text, out decimal precioRenta))
                {
                    MessageBox.Show("El precio de renta debe ser un número decimal");
                    return;
                }

                // Crear una nueva película con los datos ingresados por el usuario
                Pelicula pelicula = new Pelicula
                {
                    Nombre = TxtNombre.Text,
                    Genero = CbGenero.SelectedItem.ToString(),
                    Autores = TxtAutores.Text,
                    Existencia = existencia,
                    PrecioRenta = precioRenta,
                    Estado = CHBEstado.Checked
                };

                // Llamar al método GuardarPelicula del repositorio para guardar la película
                repositorioPeliculas.GuardarPelicula(pelicula);

                // Limpiar los controles después de guardar
                LimpiarControles();

                MessageBox.Show("Película guardada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la película: " + ex.Message);
            }
        }

        private void LimpiarControles()
        {
            // Limpiar los controles después de guardar
            TxtNombre.Text = "";
            CbGenero.SelectedItem = null;
            TxtAutores.Text = "";
            TxtExsitencia.Text = "";
            TxtPrecioRenta.Text = "";
            CHBEstado.Checked = false;
        }
    }
}
