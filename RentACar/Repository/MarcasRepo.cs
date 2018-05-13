using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    class MarcasRepo
    {
        private RentCarContext _db;

        public MarcasRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Busca todas las marcas
        /// </summary>
        /// <returns></returns>
        public List<MarcasModel> GetAllMarcas() => 
            _db.Marcas
            .Where(x => x.Id_Estado == 1)
            .Select(x => new MarcasModel()
            {
                Id = x.Id,
                Estado = x.Estado.Estado1,
                Marca = x.Descripcion
            })
            .ToList();
        /// <summary>
        /// Consigue la marca por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Marca GetMarcaById(int id) => _db.Marcas.FirstOrDefault(x => x.Id == id);
        /// <summary>
        /// Chequea si la marca existe
        /// </summary>
        /// <param name="desc"></param>
        /// <returns></returns>
        public bool CheckMarcaExists(string desc) => _db.Marcas.Any(x => x.Descripcion.ToLower().Trim() == desc.ToLower().Trim());

        public void InsertMarca(Marca mr)
        {
            if(mr.Id == 0)
            {
                _db.Marcas.Add(mr);
            }
            else
            {
                var mrc = _db.Marcas.FirstOrDefault(x => x.Id == mr.Id);
                mrc.Id_Estado = mr.Id_Estado;
                mrc.Descripcion = mr.Descripcion;
                mrc.Id_User = mr.Id_User;
            }
            _db.SaveChanges();
        }


    }
}
