namespace RentACar
{
    partial class VehiculosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.editarVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.vehiculosTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutVhMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásMenuVhItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.searchDesc = new System.Windows.Forms.TextBox();
            this.searchMod = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.searchMarca = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.searchTipoV = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.searchTipoCo = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.InspeccionBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.reporteBtn = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertVehiculoBtn
            // 
            this.insertVehiculoBtn.AutoSize = true;
            this.insertVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertVehiculoBtn.Depth = 0;
            this.insertVehiculoBtn.Location = new System.Drawing.Point(348, 116);
            this.insertVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertVehiculoBtn.Name = "insertVehiculoBtn";
            this.insertVehiculoBtn.Primary = false;
            this.insertVehiculoBtn.Size = new System.Drawing.Size(179, 36);
            this.insertVehiculoBtn.TabIndex = 0;
            this.insertVehiculoBtn.Text = "Insertar Vehiculo";
            this.insertVehiculoBtn.UseVisualStyleBackColor = true;
            this.insertVehiculoBtn.Click += new System.EventHandler(this.insertVehiculoBtn_Click);
            // 
            // editarVehiculoBtn
            // 
            this.editarVehiculoBtn.AutoSize = true;
            this.editarVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarVehiculoBtn.Depth = 0;
            this.editarVehiculoBtn.Location = new System.Drawing.Point(586, 116);
            this.editarVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarVehiculoBtn.Name = "editarVehiculoBtn";
            this.editarVehiculoBtn.Primary = false;
            this.editarVehiculoBtn.Size = new System.Drawing.Size(157, 36);
            this.editarVehiculoBtn.TabIndex = 1;
            this.editarVehiculoBtn.Text = "Editar Vehiculo";
            this.editarVehiculoBtn.UseVisualStyleBackColor = true;
            this.editarVehiculoBtn.Click += new System.EventHandler(this.editarVehiculoBtn_Click);
            // 
            // vehiculosTable
            // 
            this.vehiculosTable.AllowUserToAddRows = false;
            this.vehiculosTable.AllowUserToDeleteRows = false;
            this.vehiculosTable.AllowUserToOrderColumns = true;
            this.vehiculosTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.vehiculosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculosTable.Location = new System.Drawing.Point(112, 302);
            this.vehiculosTable.Name = "vehiculosTable";
            this.vehiculosTable.ReadOnly = true;
            this.vehiculosTable.RowTemplate.Height = 24;
            this.vehiculosTable.Size = new System.Drawing.Size(1205, 230);
            this.vehiculosTable.TabIndex = 2;
            this.vehiculosTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiculosTable_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutVhMenuItem,
            this.atrásMenuVhItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1391, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutVhMenuItem
            // 
            this.logoutVhMenuItem.Name = "logoutVhMenuItem";
            this.logoutVhMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutVhMenuItem.Text = "Logout";
            this.logoutVhMenuItem.Click += new System.EventHandler(this.logoutVhMenuItem_Click);
            // 
            // atrásMenuVhItem
            // 
            this.atrásMenuVhItem.Name = "atrásMenuVhItem";
            this.atrásMenuVhItem.Size = new System.Drawing.Size(55, 24);
            this.atrásMenuVhItem.Text = "Atrás";
            this.atrásMenuVhItem.Click += new System.EventHandler(this.atrásMenuVhItem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(79, 224);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 24);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Descripcion";
            // 
            // searchDesc
            // 
            this.searchDesc.Location = new System.Drawing.Point(195, 224);
            this.searchDesc.Name = "searchDesc";
            this.searchDesc.Size = new System.Drawing.Size(100, 22);
            this.searchDesc.TabIndex = 12;
            this.searchDesc.TextChanged += new System.EventHandler(this.searchDesc_TextChanged);
            // 
            // searchMod
            // 
            this.searchMod.Location = new System.Drawing.Point(405, 226);
            this.searchMod.Name = "searchMod";
            this.searchMod.Size = new System.Drawing.Size(100, 22);
            this.searchMod.TabIndex = 14;
            this.searchMod.TextChanged += new System.EventHandler(this.searchMod_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(314, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 24);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Modelo";
            // 
            // searchMarca
            // 
            this.searchMarca.Location = new System.Drawing.Point(588, 228);
            this.searchMarca.Name = "searchMarca";
            this.searchMarca.Size = new System.Drawing.Size(100, 22);
            this.searchMarca.TabIndex = 16;
            this.searchMarca.TextChanged += new System.EventHandler(this.searchMarca_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(519, 226);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 24);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Marca";
            // 
            // searchTipoV
            // 
            this.searchTipoV.Location = new System.Drawing.Point(836, 228);
            this.searchTipoV.Name = "searchTipoV";
            this.searchTipoV.Size = new System.Drawing.Size(129, 22);
            this.searchTipoV.TabIndex = 18;
            this.searchTipoV.TextChanged += new System.EventHandler(this.searchTipoV_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(704, 226);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(126, 24);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Tipo Vehiculo";
            // 
            // searchTipoCo
            // 
            this.searchTipoCo.Location = new System.Drawing.Point(1183, 228);
            this.searchTipoCo.Name = "searchTipoCo";
            this.searchTipoCo.Size = new System.Drawing.Size(128, 22);
            this.searchTipoCo.TabIndex = 20;
            this.searchTipoCo.TextChanged += new System.EventHandler(this.searchTipoCo_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(986, 226);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(161, 24);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Tipo Combustible";
            // 
            // InspeccionBtn
            // 
            this.InspeccionBtn.AutoSize = true;
            this.InspeccionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InspeccionBtn.Depth = 0;
            this.InspeccionBtn.Location = new System.Drawing.Point(799, 116);
            this.InspeccionBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InspeccionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.InspeccionBtn.Name = "InspeccionBtn";
            this.InspeccionBtn.Primary = false;
            this.InspeccionBtn.Size = new System.Drawing.Size(112, 36);
            this.InspeccionBtn.TabIndex = 21;
            this.InspeccionBtn.Text = "Inspeccion";
            this.InspeccionBtn.UseVisualStyleBackColor = true;
            this.InspeccionBtn.Click += new System.EventHandler(this.InspeccionBtn_Click);
            // 
            // reporteBtn
            // 
            this.reporteBtn.AutoSize = true;
            this.reporteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reporteBtn.Depth = 0;
            this.reporteBtn.Location = new System.Drawing.Point(956, 116);
            this.reporteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reporteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.reporteBtn.Name = "reporteBtn";
            this.reporteBtn.Primary = false;
            this.reporteBtn.Size = new System.Drawing.Size(87, 36);
            this.reporteBtn.TabIndex = 22;
            this.reporteBtn.Text = "Reporte";
            this.reporteBtn.UseVisualStyleBackColor = true;
            this.reporteBtn.Click += new System.EventHandler(this.reporteBtn_Click);
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 615);
            this.Controls.Add(this.reporteBtn);
            this.Controls.Add(this.InspeccionBtn);
            this.Controls.Add(this.searchTipoCo);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.searchTipoV);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.searchMarca);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.searchMod);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.searchDesc);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vehiculosTable);
            this.Controls.Add(this.editarVehiculoBtn);
            this.Controls.Add(this.insertVehiculoBtn);
            this.Name = "VehiculosForm";
            this.Text = "Rent A Car - Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton insertVehiculoBtn;
        private MaterialSkin.Controls.MaterialFlatButton editarVehiculoBtn;
        private System.Windows.Forms.DataGridView vehiculosTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutVhMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásMenuVhItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox searchDesc;
        private System.Windows.Forms.TextBox searchMod;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox searchMarca;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox searchTipoV;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox searchTipoCo;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton InspeccionBtn;
        private MaterialSkin.Controls.MaterialFlatButton reporteBtn;
    }
}