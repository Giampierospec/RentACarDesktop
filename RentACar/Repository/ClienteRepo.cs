using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    public class ClienteRepo: UserRepo
    {
        private RentCarContext _db;

        public ClienteRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Busca todos los clientes
        /// </summary>
        public List<ClienteModel> GetAllClientes() =>
            _db.Clientes
                .Where(x => x.Id_Estado == 1)
            .Select(x => new ClienteModel()
            {
                Cedula = x.Cedula,
                Estado = x.Estado.Estado1,
                Id = x.Id,
                LimiteCredito = x.LimiteCredito,
                Nombre = x.Nombre,
                NoTarjeta = x.NoTarjetaCr,
                TipoPersona = x.TipoPersona
            }).ToList();
        public Cliente GetClienteById(int id) => _db.Clientes.FirstOrDefault(x => x.Id == id);

        public bool UserExistsByCedula(string ced) => _db.Clientes.Any(x => x.Cedula.Trim() == ced.Trim());

        public void InsertCliente(Cliente cl)
        {
            if(cl.Id == 0)
            {
                _db.Clientes.Add(cl);
                _db.Usuarios.Add(cl.Usuario);
            }
            else
            {
                var cliente = _db.Clientes.FirstOrDefault(x => x.Id == cl.Id);
                cliente.Id_Estado = cl.Id_Estado;
                cliente.Cedula = cl.Cedula.Trim();
                cliente.LimiteCredito = cl.LimiteCredito;
                cliente.Nombre = cl.Nombre;
                cliente.NoTarjetaCr = cl.NoTarjetaCr.Trim();
                cliente.TipoPersona = cl.TipoPersona.Trim();
                cliente.Usuario.Id = cliente.Id_User.Value;
                cliente.Usuario.Email = cl.Usuario.Email;
                cliente.Usuario.Pass = cl.Usuario.Pass;
                cliente.Usuario.Id_Rol = cl.Usuario.Id_Rol;

            }
            _db.SaveChanges();
        }
        public List<ClienteModel> Filter(Cliente cl) =>
            _db.Clientes
               .Where(x => (x.Id_Estado == 1) &&
               (
               (cl.Cedula == null || cl.Cedula == string.Empty)?true:x.Cedula.Trim().Contains(cl.Cedula.Trim())
               ))
            .Select(x => new ClienteModel()
            {
                Cedula = x.Cedula,
                Estado = x.Estado.Estado1,
                Id = x.Id,
                LimiteCredito = x.LimiteCredito,
                Nombre = x.Nombre,
                NoTarjeta = x.NoTarjetaCr,
                TipoPersona = x.TipoPersona
            }).ToList();
    }
}
