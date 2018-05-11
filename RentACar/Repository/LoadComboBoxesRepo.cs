using RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    public class LoadComboBoxesRepo
    {
        private RentCarContext _db;

        public LoadComboBoxesRepo()
        {
            _db = new RentCarContext();
        }

        public List<Estado> GetEstado() => _db.Estadoes.ToList();
        public List<Marca> GetMarcas() => _db.Marcas.Where(x => x.Id_Estado == 1).ToList();

        public List<TipoCombustible> GetTipoCombustible() => _db.TipoCombustibles.Where(x => x.Id_Estado == 1).ToList();

        public List<Modelo> GetModelosByMarca(int marcaId) => _db.Modeloes.Where(x => x.Id_Marca == marcaId && x.Id_Estado == 1).ToList();

        public List<TipoVehiculo> GetAllTipoVehiculos() => _db.TipoVehiculoes.Where(x => x.Id_Estado == 1).ToList();
    }
}
