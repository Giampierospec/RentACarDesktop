﻿using RentACar.Context;
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
        /// <summary>
        /// Inserta el tipo de vehiculo
        /// </summary>
        /// <param name="tp"></param>
        public void InsertTipoVehiculo(TipoVehiculo tp)
        {
            if (tp.Id == 0)
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
        /// <summary>
        /// Revisa si el tipo de vehiculo existe
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool TipoVehiculoExists(string txt) => _db.TipoVehiculoes.Any(x => x.Descripcion.ToLower().Trim() == txt.ToLower().Trim() && x.Id_Estado == 1);
        /// <summary>
        /// Filtra los tipos de vehiculos
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public List<TipoVehiculoModel> Filter(TipoVehiculo tv) =>
            _db.TipoVehiculoes
            .Where(x => (x.Id_Estado == 1) &&
                    ((tv.Descripcion == null || tv.Descripcion == string.Empty) ? true : x.Descripcion.ToLower().Trim().Contains(tv.Descripcion.ToLower().Trim()))
                ).Select(x => new TipoVehiculoModel()
                {
                    TipoVehiculo = x.Descripcion,
                    Estado = x.Estado.Estado1,
                    Id = x.Id
                }).ToList();

    }
}
