using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepoClientes
    {
        public List<Cliente> Listar()
        {
            using var context = new Context();
            return context.Clientes.Include("Cuentas").ToList();
        }

        public string Agregar(Cliente cliente)
        {
            try
            {
                using var context = new Context();

                if (context.Clientes.Any(c => c.DNI == cliente.DNI))
                {
                    return "Error. Ya existe un cliente con ese DNI.";
                }

                context.Clientes.Add(cliente);
                context.SaveChanges();
                return "Cliente registrado con exito";
            }
            catch
            {
                return "Error al conectar con la BBDD.";
            }
        }

        public string Modificar(Cliente cliente)
        {
            try
            {
                using var context = new Context();

                var clienteExistente = context.Clientes.FirstOrDefault(c => c.ClienteId == cliente.ClienteId);

                if (clienteExistente == null) return "El cliente a modificar no existe.";

                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Apellido = cliente.Apellido;
                clienteExistente.DNI = cliente.DNI;
                clienteExistente.Telefono = cliente.Telefono;

                context.SaveChanges();
                return "Cliente modificado con exito";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                using var context = new Context();

                var cliente = context.Clientes.Find(id);
                if (cliente == null) return "No existe ese cliente.";

                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return "Cliente eliminado con exito.";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }
    }
}
