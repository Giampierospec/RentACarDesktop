using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
   public class RentaRepo : VehiculosRepo
    {
        private RentCarContext _db;

        public RentaRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Consiguge todas las rentass
        /// </summary>
        /// <returns></returns>
        public List<RentaModel> GetAllRentas() =>
            _db.Rentas
            .Where(x => x.Id_Estado == 1)
            .Select(x => new RentaModel
            {
                Id = x.Id,
                Cliente = x.Cliente.Nombre,
                Dias = x.Dias,
                Comentario = x.Comentario,
                Empleado = x.Empleado.Nombre,
                Estado = x.Estado.Estado1,
                Fecha = x.FechaRenta,
                FechaDevolucion = x.FechaDevolucion,
                MontoDiario = x.MontoDiario,
                MontoTotal = x.MontoTotalPorDia,
                Vehiculo = x.Vehiculo.Descripcion

            }).ToList();
        /// <summary>
        /// Consigue la renta por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Renta GetRenta(int id) => _db.Rentas.FirstOrDefault(x => x.Id == id);

        public void InsertRenta(Renta rt)
        {
            if(rt.Id== 0)
            {
                _db.Rentas.Add(rt);
            }
            else
            {
                var rent = _db.Rentas.FirstOrDefault(x => x.Id == rt.Id);
                rent.FechaRenta = rt.FechaRenta;
                rent.Id_Cliente = rt.Id_Cliente;
                rent.Id_Empleado = rt.Id_Empleado;
                rent.Id_User = rt.Id_User;
                rent.Id_Vehiculo = rt.Id_Vehiculo;
                rent.Id_Estado = rt.Id_Estado;
                rent.FechaDevolucion = rt.FechaDevolucion;
                rent.MontoDiario = rt.MontoDiario;
                rent.FechaRenta = rt.FechaRenta;
                rent.Comentario = rt.Comentario;
                rent.Dias = rt.Dias;
            }
            _db.SaveChanges();

        }
        /// <summary>
        /// Filtra por renta
        /// </summary>
        /// <param name="rm"></param>
        /// <returns></returns>
        public List<RentaModel> Filter(Renta rm) =>
            _db.Rentas
            .Where(x => (x.Id_Estado == 1) &&
            (
            ((rm.Cliente.Nombre == string.Empty || rm.Cliente.Nombre == null) ? true: x.Cliente.Nombre.Trim().ToLower().Contains(rm.Cliente.Nombre.Trim().ToLower())) &&
            ((rm.Empleado.Nombre == string.Empty || rm.Empleado.Nombre == null)?true: x.Empleado.Nombre.Trim().ToLower().Contains(rm.Empleado.Nombre.Trim().ToLower()))
            ))
            .Select(x => new RentaModel()
            {
                Id = x.Id,
                Cliente = x.Cliente.Nombre,
                Dias = x.Dias,
                Comentario = x.Comentario,
                Empleado = x.Empleado.Nombre,
                Estado = x.Estado.Estado1,
                Fecha = x.FechaRenta,
                FechaDevolucion = x.FechaDevolucion,
                MontoDiario = x.MontoDiario,
                MontoTotal = x.MontoTotalPorDia,
                Vehiculo = x.Vehiculo.Descripcion
            }).ToList();
        /// <summary>
        /// Devuelve el vehiculoRentado
        /// </summary>
        /// <param name="rt"></param>
        public void Devolver(Renta rt)
        {
            var rent = _db.Rentas.FirstOrDefault(x => x.Id == rt.Id);
            rent.FechaDevolucion = DateTime.Now;
            var vehiculo = GetVehiculoById(rent.Id_Vehiculo.Value);
            vehiculo.Id_Estado = 1;
            _db.SaveChanges();
        }

    }
}
