namespace RentACar
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.clienteTable = new System.Windows.Forms.DataGridView();
            this.editarClienteBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertClienteBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cedTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteTable
            // 
            this.clienteTable.AllowUserToAddRows = false;
            this.clienteTable.AllowUserToDeleteRows = false;
            this.clienteTable.AllowUserToOrderColumns = true;
            this.clienteTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.clienteTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteTable.Location = new System.Drawing.Point(110, 254);
            this.clienteTable.Name = "clienteTable";
            this.clienteTable.ReadOnly = true;
            this.clienteTable.RowTemplate.Height = 24;
            this.clienteTable.Size = new System.Drawing.Size(603, 299);
            this.clienteTable.TabIndex = 14;
            this.clienteTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteTable_CellClick);
            // 
            // editarClienteBtn
            // 
            this.editarClienteBtn.AutoSize = true;
            this.editarClienteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarClienteBtn.Depth = 0;
            this.editarClienteBtn.Location = new System.Drawing.Point(457, 106);
            this.editarClienteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarClienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarClienteBtn.Name = "editarClienteBtn";
            this.editarClienteBtn.Primary = false;
            this.editarClienteBtn.Size = new System.Drawing.Size(143, 36);
            this.editarClienteBtn.TabIndex = 13;
            this.editarClienteBtn.Text = "Editar Cliente";
            this.editarClienteBtn.UseVisualStyleBackColor = true;
            this.editarClienteBtn.Click += new System.EventHandler(this.editarClienteBtn_Click);
            // 
            // insertClienteBtn
            // 
            this.insertClienteBtn.AutoSize = true;
            this.insertClienteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertClienteBtn.Depth = 0;
            this.insertClienteBtn.Location = new System.Drawing.Point(170, 106);
            this.insertClienteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertClienteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertClienteBtn.Name = "insertClienteBtn";
            this.insertClienteBtn.Primary = false;
            this.insertClienteBtn.Size = new System.Drawing.Size(165, 36);
            this.insertClienteBtn.TabIndex = 12;
            this.insertClienteBtn.Text = "Insertar Cliente";
            this.insertClienteBtn.UseVisualStyleBackColor = true;
            this.insertClienteBtn.Click += new System.EventHandler(this.insertClienteBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(110, 208);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 24);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Cedula";
            // 
            // cedTxt
            // 
            this.cedTxt.Location = new System.Drawing.Point(185, 208);
            this.cedTxt.Name = "cedTxt";
            this.cedTxt.Size = new System.Drawing.Size(245, 22);
            this.cedTxt.TabIndex = 17;
            this.cedTxt.TextChanged += new System.EventHandler(this.cedTxt_TextChanged);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 579);
            this.Controls.Add(this.cedTxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.clienteTable);
            this.Controls.Add(this.editarClienteBtn);
            this.Controls.Add(this.insertClienteBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientesForm";
            this.Text = "Rent A Car - Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clienteTable;
        private MaterialSkin.Controls.MaterialFlatButton editarClienteBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertClienteBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox cedTxt;
    }
}