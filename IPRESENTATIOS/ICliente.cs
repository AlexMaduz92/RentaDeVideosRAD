using Datos.BD;
using Datos.Entidades;
using Datos.Repositories;
using Datos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IPRESENTATIOS
{
    public partial class ICliente : Form
    {
        private RepositorioClientes repositorioClientes;

        public ICliente()
        {
            InitializeComponent();
            var context = new RentaDeVideosContext();
            var repositorio = new Repository<Cliente>(context);
            repositorioClientes = new RepositorioClientes(repositorio);
            CargarClientesEnDataGridView();

            // Suscribir el evento CellClick
            DGVCliente.CellClick += DGVCliente_CellClick;
            BtnGuardar.Click += BtnGuardar_Click;
            BtnActualizar.Click += BtnActualizar_Click;
            BtnEliminar.Click += BtnEliminar_Click;

            // Configurar campos no editables
            TxtIdCliente.ReadOnly = true;
            TxtIdCliente.Enabled = false;
            DGVCliente.ReadOnly = true;
            DGVCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarClientesEnDataGridView()
        {
            using (var context = new RentaDeVideosContext())
            {
                var clientes = context.Clientes.Where(c => c.Estado).ToList();
                DGVCliente.DataSource = clientes;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de guardar este cliente?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (CamposValidosCliente())
                {
                    try
                    {
                        GuardarCliente();
                        LimpiarControlesCliente();
                        MessageBox.Show("Cliente guardado correctamente");
                        CargarClientesEnDataGridView(); // Volver a cargar los clientes en el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el cliente: " + ex.Message);
                    }
                }
            }
        }

        private bool CamposValidosCliente()
        {
            // Validar que los campos obligatorios estén llenos
            if (string.IsNullOrWhiteSpace(TxtNombres.Text) ||
                string.IsNullOrWhiteSpace(TxtApellidos.Text) ||
                DTPFechaIngreso.Value == null)
            {
                MessageBox.Show("Debes completar todos los campos obligatorios para guardar el cliente");
                return false;
            }

            return true;
        }

        private void GuardarCliente()
        {
            try
            {
                // Crear un nuevo cliente con los datos ingresados por el usuario
                Cliente cliente = new Cliente
                {
                    Nombre = TxtNombres.Text,
                    Apellidos = TxtApellidos.Text,
                    FechaIngreso = DTPFechaIngreso.Value,
                    Estado = CBActivo.Checked
                };

                // Llamar al método GuardarCliente del repositorio para guardar el cliente
                repositorioClientes.GuardarCliente(cliente);

                // Limpiar los controles después de guardar
                LimpiarControlesCliente();

                MessageBox.Show("Cliente guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }

        private void DGVCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCliente.Rows[e.RowIndex];

                // Asignar los valores de la fila seleccionada a los controles del formulario
                TxtIdCliente.Text = row.Cells[0].Value.ToString(); 
                TxtNombres.Text = row.Cells[1].Value.ToString();
                TxtApellidos.Text = row.Cells[2].Value.ToString(); 
                DTPFechaIngreso.Value = (DateTime)row.Cells[3].Value; 
                CBActivo.Checked = (bool)row.Cells[4].Value; 
            }
        }



        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DGVCliente.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de actualizar este cliente?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Obtener el cliente seleccionado en el DataGridView
                        Cliente cliente = (Cliente)DGVCliente.SelectedRows[0].DataBoundItem;

                        // Actualizar los datos del cliente con la información de los controles del formulario
                        cliente.Nombre = TxtNombres.Text;
                        cliente.Apellidos = TxtApellidos.Text;
                        cliente.FechaIngreso = DTPFechaIngreso.Value;
                        cliente.Estado = CBActivo.Checked;

                        // Guardar los cambios en el repositorio
                        repositorioClientes.ActualizarCliente(cliente);

                        // Actualizar el DataGridView
                        CargarClientesEnDataGridView();

                        MessageBox.Show("Cliente actualizado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para actualizar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVCliente.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el cliente seleccionado en el DataGridView
                    Cliente cliente = (Cliente)DGVCliente.SelectedRows[0].DataBoundItem;

                    // Mostrar un cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario confirma la eliminación, proceder
                    if (result == DialogResult.Yes)
                    {
                        // Cambiar el estado del cliente a inactivo
                        cliente.Estado = false; // o el valor que represente "inactivo"

                        // Actualizar el cliente en el repositorio
                        repositorioClientes.ActualizarCliente(cliente);

                        // Actualizar el DataGridView
                        CargarClientesEnDataGridView();

                        MessageBox.Show("Cliente eliminado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar");
            }
        }




        private void LimpiarControlesCliente()
        {
            // Limpiar los controles después de guardar
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            DTPFechaIngreso.Value = DateTime.Now;
            CBActivo.Checked = false;
        }
    }
}
