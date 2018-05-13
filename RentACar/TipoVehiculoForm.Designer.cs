namespace RentACar
{
    partial class TipoVehiculoForm
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
            this.TVehiculosTable = new System.Windows.Forms.DataGridView();
            this.editarVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertTVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutTVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásMenuTvItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TVehiculosTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TVehiculosTable
            // 
            this.TVehiculosTable.AllowUserToAddRows = false;
            this.TVehiculosTable.AllowUserToDeleteRows = false;
            this.TVehiculosTable.AllowUserToOrderColumns = true;
            this.TVehiculosTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TVehiculosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TVehiculosTable.Location = new System.Drawing.Point(268, 216);
            this.TVehiculosTable.Name = "TVehiculosTable";
            this.TVehiculosTable.ReadOnly = true;
            this.TVehiculosTable.RowTemplate.Height = 24;
            this.TVehiculosTable.Size = new System.Drawing.Size(379, 205);
            this.TVehiculosTable.TabIndex = 5;
            this.TVehiculosTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TVehiculosTable_CellContentClick);
            // 
            // editarVehiculoBtn
            // 
            this.editarVehiculoBtn.AutoSize = true;
            this.editarVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarVehiculoBtn.Depth = 0;
            this.editarVehiculoBtn.Location = new System.Drawing.Point(498, 95);
            this.editarVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarVehiculoBtn.Name = "editarVehiculoBtn";
            this.editarVehiculoBtn.Primary = false;
            this.editarVehiculoBtn.Size = new System.Drawing.Size(199, 36);
            this.editarVehiculoBtn.TabIndex = 4;
            this.editarVehiculoBtn.Text = "Editar Tipo Vehiculo";
            this.editarVehiculoBtn.UseVisualStyleBackColor = true;
            this.editarVehiculoBtn.Click += new System.EventHandler(this.editarVehiculoBtn_Click);
            // 
            // insertTVehiculoBtn
            // 
            this.insertTVehiculoBtn.AutoSize = true;
            this.insertTVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertTVehiculoBtn.Depth = 0;
            this.insertTVehiculoBtn.Location = new System.Drawing.Point(211, 95);
            this.insertTVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertTVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertTVehiculoBtn.Name = "insertTVehiculoBtn";
            this.insertTVehiculoBtn.Primary = false;
            this.insertTVehiculoBtn.Size = new System.Drawing.Size(221, 36);
            this.insertTVehiculoBtn.TabIndex = 3;
            this.insertTVehiculoBtn.Text = "Insertar Tipo Vehiculo";
            this.insertTVehiculoBtn.UseVisualStyleBackColor = true;
            this.insertTVehiculoBtn.Click += new System.EventHandler(this.insertTVehiculoBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutTVMenuItem,
            this.atrásMenuTvItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutTVMenuItem
            // 
            this.logoutTVMenuItem.Name = "logoutTVMenuItem";
            this.logoutTVMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutTVMenuItem.Text = "Logout";
            this.logoutTVMenuItem.Click += new System.EventHandler(this.logoutTVMenuItem_Click);
            // 
            // atrásMenuTvItem
            // 
            this.atrásMenuTvItem.Name = "atrásMenuTvItem";
            this.atrásMenuTvItem.Size = new System.Drawing.Size(55, 24);
            this.atrásMenuTvItem.Text = "Atrás";
            this.atrásMenuTvItem.Click += new System.EventHandler(this.atrásMenuTvItem_Click);
            // 
            // TipoVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 519);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TVehiculosTable);
            this.Controls.Add(this.editarVehiculoBtn);
            this.Controls.Add(this.insertTVehiculoBtn);
            this.Name = "TipoVehiculoForm";
            this.Text = "Rent A Car - Tipo Vehiculos";
            this.Load += new System.EventHandler(this.TipoVehiculoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TVehiculosTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TVehiculosTable;
        private MaterialSkin.Controls.MaterialFlatButton editarVehiculoBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertTVehiculoBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutTVMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásMenuTvItem;
    }
}