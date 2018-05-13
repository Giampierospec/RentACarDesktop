﻿using MaterialSkin.Controls;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class ModelosForm : MaterialForm
    {
        private int _userId;
        private UserRepo _userRepo;
        private ModeloRepo _modeloRepo;
        private int _modeloId = 0;
        public ModelosForm(int userId = 0)
        {
            _userId = userId;
            _userRepo = new UserRepo();
            _modeloRepo = new ModeloRepo();
            InitializeComponent();
        }

        private void ModelosForm_Load(object sender, EventArgs e)
        {
            var user = _userRepo.GetUserById(_userId);
            if(user.Id_Rol == 2)
            {
                Utils.Validate.LockBtns(this);
            }
            modeloTable.DataSource = _modeloRepo.GetAllModelos();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void modeloTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _modeloId = int.Parse(modeloTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void insertModeloBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Thread.Sleep(2000);
            var modifyModelo = new ModifyModelos(_userId, 0, "Insertar");
            Hide();
            modifyModelo.ShowDialog();
            Close();
        }

        private void editarModeloBtn_Click(object sender, EventArgs e)
        {
            if(_modeloId == 0)
            {
                MessageBox.Show("Elija una fila para editar");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                Thread.Sleep(2000);
                var modifyModelo = new ModifyModelos(_userId, _modeloId, "Editar");
                Hide();
                modifyModelo.ShowDialog();
                Close();
            }
        }
    }
}
