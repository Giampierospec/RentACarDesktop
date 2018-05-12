﻿using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    class VehiculosRepo
    {
        private RentCarContext _db;

        public VehiculosRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Consigue todos los vehiculos que esten activos
        /// </summary>
        /// <returns></returns>
        public List<VehiculosModel> GetAllVehiculos() =>
            _db.Vehiculoes
            .Where(x => x.Id_Estado == 1)
            .Select(x => new VehiculosModel()
            {
                Id = x.Id,
                Estado = x.Estado.Estado1,
                Descripcion = x.Descripcion,
                Marca = x.Marca.Descripcion,
                Modelo = x.Modelo.Descripcion,
                NoChasis = x.NoChasis,
                NoPlaca = x.NoPlaca,
                NoMotor = x.NoMotor,
                TipoCombustible = x.TipoCombustible.Descripcion,
                TipoVehiculo = x.TipoVehiculo.Descripcion
            })
            .ToList();
        /// <summary>
        /// Consigue un vehiculo por el Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Vehiculo GetVehiculoById(int id) => _db.Vehiculoes.FirstOrDefault(x => x.Id == id);
        /// <summary>
        /// Inserta el vehiculo
        /// </summary>
        /// <param name="vh"></param>
        public void InsertVehiculos(Vehiculo vh)
        {
            if (vh.Id == 0)
            {
                _db.Vehiculoes.Add(vh);
            }
            else
            {
                var veh = _db.Vehiculoes.FirstOrDefault(x => x.Id == vh.Id);
                veh.Id_Estado = vh.Id_Estado;
                veh.Id_Marca = vh.Id_Marca;
                veh.Descripcion = vh.Descripcion;
                veh.Id_Modelo = vh.Id_Modelo;
                veh.Id_User = vh.Id_User;
                veh.Id_Tipo_Combustible = vh.Id_Tipo_Combustible;
                veh.Id_TipoVehiculo = vh.Id_TipoVehiculo;
                veh.NoChasis = vh.NoChasis;
                veh.NoMotor = vh.NoMotor;
                veh.NoPlaca = vh.NoPlaca;
            }
            _db.SaveChanges();
        }
        /// <summary>
        /// Verifica si el vehiculo ya existe
        /// </summary>
        /// <param name="desc"></param>
        /// <returns></returns>
        public bool VehiculoExists(string desc) => _db.Vehiculoes.Any(x => x.Descripcion.Trim().ToLower() == desc.Trim().ToLower());
    }
}
