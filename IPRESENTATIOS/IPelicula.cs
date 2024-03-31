using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Datos.BD;
using Datos.Entidades;
using Datos.Repositories;
using Datos.Repository;

namespace IPRESENTATIOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
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
            var repositorio = new Repository<Pelicula>(context); // Crear el repositorio con el contexto
            repositorioPeliculas = new RepositorioPeliculas(repositorio); // Inicializar el repositorio de películas
        }

        private void CargarGeneros()
        {
            CbGenero.Items.Add("Acción");
            CbGenero.Items.Add("Comedia");
            CbGenero.Items.Add("Drama");
        }

        private List<Pelicula> ObtenerPeliculas()
        {
            return repositorioPeliculas.ObtenerPeliculas();
        }

        private void CargarDatos()
        {
            // Obtener todas las películas
            List<Pelicula> peliculas = repositorioPeliculas.ObtenerPeliculas();

            // Verificar si la lista de películas es nula antes de usarla
            if (peliculas != null)
            {
                // Filtrar las películas por el estado activo
                var peliculasActivas = peliculas.Where(p => p.Estado).ToList();

                // Mostrar las películas activas en el DataGridView
                DGVVista.DataSource = peliculasActivas;
            }
            else
            {
                // Si la lista es nula, mostrar un mensaje o realizar alguna acción
                MessageBox.Show("No se pudieron obtener las películas.");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtAutores.Text)
                && !string.IsNullOrEmpty(TxtExsitencia.Text) && !string.IsNullOrEmpty(TxtPrecioRenta.Text))
            {
                if (CbGenero.SelectedItem != null)
                {
                    // Crear una nueva película con los datos ingresados por el usuario
                    Pelicula pelicula = new Pelicula
                    {
                        Nombre = TxtNombre.Text,
                        Genero = CbGenero.SelectedItem.ToString(),
                        Autores = TxtAutores.Text,
                        Existencia = Convert.ToInt32(TxtExsitencia.Text),
                        PrecioRenta = Convert.ToDecimal(TxtPrecioRenta.Text),
                        Estado = CHBEstado.Checked
                    };

                    // Llamar al método GuardarPelicula del repositorio para guardar la película
                    repositorioPeliculas.GuardarPelicula(pelicula);
                    MessageBox.Show("Película guardada correctamente");
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un género para la película");
                }
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos para guardar la película");
            }
        }

        private void LimpiarControles()
        {
            TxtNombre.Text = "";
            CbGenero.SelectedItem = null;
            TxtAutores.Text = "";
            TxtExsitencia.Text = "";
            TxtPrecioRenta.Text = "";
            CHBEstado.Checked = false;
        }
    }
}
