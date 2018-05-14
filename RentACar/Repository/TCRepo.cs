using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    class TCRepo
    {
        private RentCarContext _db;

        public TCRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Busca todos los tipos de combustible
        /// </summary>
        /// <returns></returns>
        public List<TipoCombustibleModel> GetAllTipoCombustible() =>
            _db.TipoCombustibles
             .Where(x => x.Id_Estado == 1)
            .Select(x => new TipoCombustibleModel()
            {
                Id = x.Id,
                Estado = x.Estado.Estado1,
                TipoCombustible = x.Descripcion
            })
            .ToList();
        /// <summary>
        /// Consigue el tipo Combustible Por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TipoCombustible GetTipoCombustibleById(int id) =>
            _db.TipoCombustibles.FirstOrDefault(x => x.Id == id);

        public void InsertTipoCombustible(TipoCombustible tc)
        {
            if(tc.Id == 0)
            {
                _db.TipoCombustibles.Add(tc);
            }
            else
            {
                var tcb = _db.TipoCombustibles.FirstOrDefault(x => x.Id == tc.Id);
                tcb.Id_Estado = tc.Id_Estado;
                tcb.Id_User = tc.Id_User;
                tcb.Descripcion = tcb.Descripcion;
            }
            _db.SaveChanges();
        }
        /// <summary>
        /// Consigue si existe el tipoCombustible
        /// </summary>
        /// <param name="desc"></param>
        /// <returns></returns>
        public bool CheckIfTipoCombustibleExists(string desc) =>
            _db.TipoCombustibles.Any(x => x.Descripcion.ToLower().Trim() == desc.ToLower().Trim() && x.Id_Estado == 1);


    }
}
