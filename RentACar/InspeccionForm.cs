﻿using MaterialSkin.Controls;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class InspeccionForm : MaterialForm
    {
        private int _userId;
        private int _vehiculoId;
        private InspeccionRepository _insRepo;
        private UserRepo _userRepo;
        private int _inspId = 0;

        public InspeccionForm(int userId = 0, int vehiculoId = 0)
        {
            _userId = userId;
            _vehiculoId = vehiculoId;
            _insRepo = new InspeccionRepository();
            _userRepo = new UserRepo();
            InitializeComponent();
        }

        private void InspeccionForm_Load(object sender, EventArgs e)
        {
            var user = _userRepo.GetUserById(_userId);
            if(user.Id_Rol == 2)
            {
                editarInsBtn.Enabled = false;
                rentarBtn.Enabled = false;
            }
            inspeccionTable.DataSource = _insRepo.GetAllInspeccion();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void editarInsBtn_Click(object sender, EventArgs e)
        {
            if(_inspId == 0)
            {
                MessageBox.Show("Escoja una fila para editar");
            }
            else
            {
                var vehiculoId = _insRepo.GetVehiculoId(_inspId).Value;
                Utils.Returning.ReturnToPreviousForm(this, new ModifyInspeccion(_userId,vehiculoId, _inspId, "Insertar"));
            }
        }

        private void inspeccionTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _inspId = int.Parse(inspeccionTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void rentarBtn_Click(object sender, EventArgs e)
        {
            if(_inspId == 0)
            {
                MessageBox.Show("Escoja una fila para Rentar");
            }
            else
            {
                var vehiculoId = _insRepo.GetVehiculoId(_inspId).Value;
                Utils.Returning.ReturnToPreviousForm(this, new ModifyRenta(_userId, vehiculoId, 0, _inspId,"Crear"));
            }
        }
    }
}
