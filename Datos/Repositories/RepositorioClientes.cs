using Datos.Entidades;
using Datos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositories
{
    public class RepositorioClientes
    {
        private IRepository<Cliente> _repositorio;

        public RepositorioClientes(IRepository<Cliente> repositorio)
        {
            _repositorio = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
        }

        public List<Cliente> ObtenerClientes()
        {
            return _repositorio.GetAll().ToList();
        }

        public void GuardarCliente(Cliente cliente)
        {
            try
            {
                _repositorio.Insert(cliente);
                _repositorio.SaveChanges(); // Guardar los cambios en la base de datos
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                Console.WriteLine("Error al guardar el cliente: " + ex.Message);
            }
        }

        public void ActualizarCliente(Cliente cliente)
        {
            try
            {
                _repositorio.Update(cliente);
                _repositorio.SaveChanges();
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
            }
        }

        public void EliminarCliente(Cliente cliente, Action<string> mostrarError)
        {
            try
            {
                _repositorio.Delete(cliente);
                _repositorio.SaveChanges();
                mostrarError?.Invoke("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                mostrarError?.Invoke("Error al eliminar el cliente: " + ex.Message);
            }
        }



    }
}
