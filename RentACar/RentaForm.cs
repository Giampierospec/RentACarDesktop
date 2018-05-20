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
    public partial class RentaForm : MaterialForm
    {
        private int _userId;
        private int _vehiculoId;
        private RentaRepo _rentaRepo;
        private UserRepo _userRepo;
        private int _rentaId = 0;

        public RentaForm(int userId = 0, int vehiculoId = 0)
        {
            _userId = userId;
            _vehiculoId = vehiculoId;
            _rentaRepo = new RentaRepo();
            _userRepo = new UserRepo();
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void RentaForm_Load(object sender, EventArgs e)
        {
            rentaTable.DataSource = _rentaRepo.GetAllRentas();
            var user = _userRepo.GetUserById(_userId);
            if (user.Id_Rol == 2)
            {
                devolverBtn.Enabled = false;
                editarRenta.Enabled = false;
            }
        }

        private void devolverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rentaId == 0)
                {
                    MessageBox.Show("Escoja una fila para Devolver");
                }
                else
                {
                    Utils.Validate.LockBtns(this);
                    _rentaRepo.Devolver(new Context.Renta()
                    {
                        Id = _rentaId
                    });
                    if (MessageBox.Show("Vehiculo Devuelto") == DialogResult.OK)
                    {
                        Utils.Returning.ReturnToPreviousForm(this, new VehiculosForm(_userId));
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ocurrio un error al devolver");
            }
        }

        private void rentaTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _rentaId = int.Parse(rentaTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void editarRenta_Click(object sender, EventArgs e)
        {
            if(_rentaId == 0)
            {
                MessageBox.Show("Escoja una fila para editar");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                Utils.Returning.ReturnToPreviousForm(this, new ModifyRenta(_userId, _vehiculoId, _rentaId, 0, "Editar"));
            }
        }
    }
}