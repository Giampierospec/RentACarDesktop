using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    class ModeloRepo
    {
        private RentCarContext _db;

        public ModeloRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Consigue todos los  modelos
        /// </summary>
        /// <returns></returns>
        public List<ModeloModel> GetAllModelos() =>
            _db.Modeloes
                .Where(x => x.Id_Estado == 1)
                .Select(x => new ModeloModel()
                {
                    Modelo = x.Descripcion,
                    Id = x.Id,
                    Estado = x.Estado.Estado1,
                    Marca = x.Marca.Descripcion
                }).ToList();
        /// <summary>
        /// Consigue el modelo por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Modelo GetModeloById(int id) => _db.Modeloes.FirstOrDefault(x => x.Id == id);
        /// <summary>
        /// Chequea si el modelo ya existe
        /// </summary>
        /// <param name="desc"></param>
        /// <returns></returns>
        public bool CheckIfModeloExists(string desc) => _db.Modeloes.Any(x => x.Descripcion.ToLower().Trim() == desc.ToLower().Trim());

        public void InsertModelo(Modelo md)
        {
            if(md.Id == 0)
            {
                _db.Modeloes.Add(md);
            }
            else
            {
                var mod = _db.Modeloes.FirstOrDefault(x => x.Id == md.Id);
                mod.Id_Estado = md.Id_Estado;
                mod.Descripcion = md.Descripcion;
                mod.Id_Marca = md.Id_Marca;
                mod.Id_User = md.Id_User;
                
            }
            _db.SaveChanges();
        }
    }
}
