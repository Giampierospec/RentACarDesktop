namespace RentACar
{
    partial class MarcasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcasForm));
            this.marcaTable = new System.Windows.Forms.DataGridView();
            this.editarMarcaBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertMarcaBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutMarcaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcaTable
            // 
            this.marcaTable.AllowUserToAddRows = false;
            this.marcaTable.AllowUserToDeleteRows = false;
            this.marcaTable.AllowUserToOrderColumns = true;
            this.marcaTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.marcaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marcaTable.Location = new System.Drawing.Point(198, 266);
            this.marcaTable.Name = "marcaTable";
            this.marcaTable.ReadOnly = true;
            this.marcaTable.RowTemplate.Height = 24;
            this.marcaTable.Size = new System.Drawing.Size(379, 205);
            this.marcaTable.TabIndex = 8;
            this.marcaTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marcaTable_CellClick);
            // 
            // editarMarcaBtn
            // 
            this.editarMarcaBtn.AutoSize = true;
            this.editarMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarMarcaBtn.Depth = 0;
            this.editarMarcaBtn.Location = new System.Drawing.Point(455, 90);
            this.editarMarcaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarMarcaBtn.Name = "editarMarcaBtn";
            this.editarMarcaBtn.Primary = false;
            this.editarMarcaBtn.Size = new System.Drawing.Size(135, 36);
            this.editarMarcaBtn.TabIndex = 7;
            this.editarMarcaBtn.Text = "Editar Marca";
            this.editarMarcaBtn.UseVisualStyleBackColor = true;
            this.editarMarcaBtn.Click += new System.EventHandler(this.editarMarcaBtn_Click);
            // 
            // insertMarcaBtn
            // 
            this.insertMarcaBtn.AutoSize = true;
            this.insertMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertMarcaBtn.Depth = 0;
            this.insertMarcaBtn.Location = new System.Drawing.Point(168, 90);
            this.insertMarcaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertMarcaBtn.Name = "insertMarcaBtn";
            this.insertMarcaBtn.Primary = false;
            this.insertMarcaBtn.Size = new System.Drawing.Size(157, 36);
            this.insertMarcaBtn.TabIndex = 6;
            this.insertMarcaBtn.Text = "Insertar Marca";
            this.insertMarcaBtn.UseVisualStyleBackColor = true;
            this.insertMarcaBtn.Click += new System.EventHandler(this.insertMarcaBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutMarcaMenuItem,
            this.atrásMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutMarcaMenuItem
            // 
            this.logoutMarcaMenuItem.Name = "logoutMarcaMenuItem";
            this.logoutMarcaMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutMarcaMenuItem.Text = "Logout";
            this.logoutMarcaMenuItem.Click += new System.EventHandler(this.logoutMarcaMenuItem_Click);
            // 
            // atrásMenuItem
            // 
            this.atrásMenuItem.Name = "atrásMenuItem";
            this.atrásMenuItem.Size = new System.Drawing.Size(55, 24);
            this.atrásMenuItem.Text = "Atrás";
            this.atrásMenuItem.Click += new System.EventHandler(this.atrásMenuItem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(217, 171);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Marca";
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(287, 172);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(276, 22);
            this.marcaTxt.TabIndex = 11;
            this.marcaTxt.TextChanged += new System.EventHandler(this.marcaTxt_TextChanged);
            // 
            // MarcasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 560);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.marcaTable);
            this.Controls.Add(this.editarMarcaBtn);
            this.Controls.Add(this.insertMarcaBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MarcasForm";
            this.Text = "Rent A Car - Marcas";
            this.Load += new System.EventHandler(this.MarcasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcaTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView marcaTable;
        private MaterialSkin.Controls.MaterialFlatButton editarMarcaBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertMarcaBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutMarcaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox marcaTxt;
    }
}