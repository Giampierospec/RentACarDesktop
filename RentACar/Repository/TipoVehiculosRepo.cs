using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    class TipoVehiculosRepo
    {
        private RentCarContext _db;

        public TipoVehiculosRepo()
        {
            _db = new RentCarContext();
        }
        public TipoVehiculo GetTipoVehiculoById(int tId) => _db.TipoVehiculoes.FirstOrDefault(x => x.Id == tId);

        public List<TipoVehiculoModel> GetAllTipoVehiculos() =>
            _db.TipoVehiculoes
            .Where(x => x.Id_Estado == 1)
            .Select(x => new TipoVehiculoModel()
            {
                TipoVehiculo = x.Descripcion,
                Estado = x.Estado.Estado1,
                Id = x.Id
            })
            .ToList();

        public void InsertTipoVehiculo(TipoVehiculo tp)
        {
            if(tp.Id == 0)
            {
                _db.TipoVehiculoes.Add(tp);
            }
            else
            {
                var tpUp = _db.TipoVehiculoes.FirstOrDefault(tpl => tpl.Id == tp.Id);
                tpUp.Id_Estado = tp.Id_Estado;
                tpUp.Descripcion = tp.Descripcion;
                tpUp.Id_User = tp.Id_User;
            }
            _db.SaveChanges();
        }
        public bool TipoVehiculoExists(string txt) => _db.TipoVehiculoes.Any(x => x.Descripcion.ToLower().Trim() == txt.ToLower().Trim());
    }
}
