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

            // Suscribir el evento CellClick
            DGVVista.CellClick += DGVVista_CellClick;
            BtnActualizar.Click += BtnActualizar_Click;
            BtnEliminar.Click += BtnEliminar_Click;

            // TxtId
            TxtId.Text = (context.Peliculas.Max(p => (int?)p.PeliculaId) ?? 0 + 1).ToString();
            TxtId.Enabled = false;

            // CbGenero
            List<string> generos = new List<string>
    {
        "Acción", "Animación", "Anime", "Aventura", "Bélico", "Ciencia Ficción",
        "Crimen", "Comedia", "Documental", "Drama", "Fantasía", "Historia",
        "Musical", "Misterio", "Terror", "Suspenso", "Romance"
    };
            CbGenero.DataSource = generos;
            CbGenero.DropDownStyle = ComboBoxStyle.DropDownList;

            // DGVVista
            DGVVista.ReadOnly = true;
            DGVVista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarGeneros()
        {
            CbGenero.Items.AddRange(new string[]
            {
        "Acción", "Animación", "Anime", "Aventura", "Bélico", "Ciencia Ficción",
        "Crimen", "Comedia", "Documental", "Drama", "Fantasía", "Historia",
        "Musical", "Misterio", "Terror", "Suspenso", "Romance"
            });
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de guardar esta película?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
        }


        private void CargarPeliculasEnDataGridView()
        {
            using (var context = new RentaDeVideosContext())
            {
                var peliculasActivas = context.Peliculas.Where(p => p.Estado == true).ToList();
                DGVVista.DataSource = peliculasActivas;
            }
        }
        private void DGVVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVVista.Rows[e.RowIndex];

                // Asignar los valores de la fila seleccionada a los controles del formulario
                TxtId.Text = row.Cells["PeliculaId"].Value.ToString();
                TxtNombre.Text = row.Cells["Nombre"].Value.ToString();
                CbGenero.SelectedItem = row.Cells["Genero"].Value.ToString();
                TxtAutores.Text = row.Cells["Autores"].Value.ToString();
                TxtExsitencia.Text = row.Cells["Existencia"].Value.ToString();
                TxtPrecioRenta.Text = row.Cells["PrecioRenta"].Value.ToString();
                CHBEstado.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);
            }
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DGVVista.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de actualizar esta película?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Obtener la película seleccionada en el DataGridView
                        Pelicula pelicula = (Pelicula)DGVVista.SelectedRows[0].DataBoundItem;

                        // Actualizar los datos de la película con la información de los controles del formulario
                        pelicula.Nombre = TxtNombre.Text;
                        pelicula.Genero = CbGenero.SelectedItem.ToString();
                        pelicula.Autores = TxtAutores.Text;
                        pelicula.Existencia = int.Parse(TxtExsitencia.Text);
                        pelicula.PrecioRenta = decimal.Parse(TxtPrecioRenta.Text);
                        pelicula.Estado = CHBEstado.Checked;

                        // Guardar los cambios en el repositorio
                        repositorioPeliculas.ActualizarPelicula(pelicula);

                        // Actualizar el DataGridView
                        CargarPeliculasEnDataGridView();

                        MessageBox.Show("Película actualizada correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la película: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película para actualizar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVVista.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la película seleccionada en el DataGridView
                    Pelicula pelicula = (Pelicula)DGVVista.SelectedRows[0].DataBoundItem;

                    // Mostrar un cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar la película?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario confirma la eliminación, proceder
                    if (result == DialogResult.Yes)
                    {
                        // Cambiar el estado de la película a inactivo (por ejemplo, false)
                        pelicula.Estado = false; // o el valor que represente "inactivo"

                        // Actualizar la película en el repositorio
                        repositorioPeliculas.ActualizarPelicula(pelicula);

                        // Actualizar el DataGridView
                        CargarPeliculasEnDataGridView();

                        MessageBox.Show("Película eliminada correctamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la película: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película para eliminar");
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
