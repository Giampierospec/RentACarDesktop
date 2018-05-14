﻿using RentACar.Context;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Repository
{
    class EmpleadosRepo
    {
        private RentCarContext _db;

        public EmpleadosRepo()
        {
            _db = new RentCarContext();
        }
        /// <summary>
        /// Consigue todos los empleados activos
        /// </summary>
        /// <returns></returns>
        public List<EmpleadoModel> GetAllEmpleados() =>
            _db.Empleadoes
            .Where(x => x.Id_Estado == 1)
            .Select(x => new EmpleadoModel()
            {
                Cedula = x.Cedula,
                Comision = x.Comision,
                Estado = x.Estado.Estado1,
                FechaIngreso = x.FechaIngreso,
                Nombre = x.Nombre,
                Tanda = x.Tanda

            }).ToList();
        public Empleado GetEmpleadoById(int id) => _db.Empleadoes.FirstOrDefault(x => x.Id == id);
        public bool GetEmpleadoByEmail(string email) => _db.Empleadoes.Any(x => x.Usuario.Email.Trim() == email.Trim() && x.Id_Estado == 1);
        /// <summary>
        /// Consigue al empleado por cedula
        /// </summary>
        /// <param name="ced"></param>
        /// <returns></returns>
        public bool GetEmpleadoByCedula(string ced) => _db.Empleadoes.Any(x => x.Cedula.Trim() == ced.Trim());
        /// <summary>
        /// Inserta el empleado
        /// </summary>
        /// <param name="em"></param>
        public void InsertEmpleado(Empleado em)
        {
            if(em.Id == 0)
            {
                _db.Empleadoes.Add(em);
                _db.Usuarios.Add(em.Usuario);
            }
            else
            {
                var emp = _db.Empleadoes.FirstOrDefault(x => x.Id == em.Id);
                emp.Id_Estado = em.Id_Estado;
                emp.Cedula = em.Cedula;
                emp.Comision = em.Comision;
                emp.Nombre = em.Nombre;
                emp.FechaIngreso = em.FechaIngreso;
                emp.Usuario.Email = em.Usuario.Email;
                emp.Usuario.Pass = em.Usuario.Pass;
                emp.Usuario.Id_Rol = em.Usuario.Id_Rol;
            }
        }
    }
}