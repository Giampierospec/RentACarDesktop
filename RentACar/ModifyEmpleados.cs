using MaterialSkin.Controls;
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
    public partial class ModifyEmpleados : MaterialForm
    {
        private int _userId;
        private int _empleadoId;
        private string _keyword;
        private LoadComboBoxesRepo _loadCombo;
        private EmpleadosRepo _empleadoRepo;

        public ModifyEmpleados(int userId = 0, int empleadoId = 0, string keyword="")
        {
            InitializeComponent();
            _userId = userId;
            _empleadoId = empleadoId;
            _keyword = keyword;
            _loadCombo = new LoadComboBoxesRepo();
            _empleadoRepo = new EmpleadosRepo();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new EmpleadosForm(_userId));
        }
    }
}
