using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    public class InspeccionRepository: VehiculosRepo
    {
        private RentCarContext _db;

        public InspeccionRepository()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Consigue Los Inspecciones de Modelos
        /// </summary>
        /// <returns></returns>
        public List<InspeccionModel> GetAllInspeccion() =>
            _db.Inspeccions
                .Where(x => x.Id_Estado == 1)
                .Select(x => new InspeccionModel() {
                    Cliente = x.Cliente.Nombre.Trim(),
                    Estado = x.Estado.Estado1.Trim(),
                    CantidadCombustible = x.CantidadCombustible,
                    Empleado = x.Empleado.Nombre,
                    EstadoGomas = x.EstadoGomas,
                    Fecha = x.Fecha,
                    Gato = x.TieneGato,
                    GomaRespuesta = x.GomaRepuesta,
                    Ralladuras = x.Ralladuras,
                    RoturasCristal = x.TieneRoturasCristal,
                    Id = x.Id,
                    Vehiculo = x.Vehiculo.Descripcion

                }).ToList();
        public Inspeccion GetInspeccionById(int id) => _db.Inspeccions.FirstOrDefault(x => x.Id == id);
        /// <summary>
        /// Consigue el Id del Vehiculo Asociado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int? GetVehiculoId(int id) => _db.Inspeccions.FirstOrDefault(x => x.Id == id)?.Id_Vehiculo;
        /// <summary>
        /// Insertar inspeccion
        /// </summary>
        /// <param name="inspeccion"></param>
        public void InsertInspeccion(Inspeccion inspeccion)
        {
            if(inspeccion.Id == 0)
            {
                _db.Inspeccions.Add(inspeccion);
            }
            else
            {
                var ins = _db.Inspeccions.FirstOrDefault(x => x.Id == inspeccion.Id);
                ins.Id_Cliente = inspeccion.Id_Cliente;
                ins.Id_Empleado = inspeccion.Id_Empleado;
                ins.Id_Estado = inspeccion.Id_Estado;
                ins.Id_User = inspeccion.Id_User;
                ins.Id_Vehiculo = inspeccion.Id_Vehiculo;
                ins.Ralladuras = inspeccion.Ralladuras;
                ins.TieneGato = inspeccion.TieneGato;
                ins.TieneRoturasCristal = inspeccion.TieneRoturasCristal;
                ins.CantidadCombustible = inspeccion.CantidadCombustible;
                ins.EstadoGomas = inspeccion.EstadoGomas;
                ins.Fecha = inspeccion.Fecha;

            }
            _db.SaveChanges();

        }
        /// <summary>
        /// Cambiar Estado de Inspeccion
        /// </summary>
        /// <param name="ins"></param>
        public void CambiarEstado(Inspeccion ins)
        {
            var insp = _db.Inspeccions.FirstOrDefault(x => x.Id == ins.Id);
            insp.Id_Estado = ins.Id_Estado;
            _db.SaveChanges();
        }
        

    }
}
