namespace RentACar
{
    partial class ModelosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelosForm));
            this.modeloTable = new System.Windows.Forms.DataGridView();
            this.editarModeloBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertModeloBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.modTxt = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.reporteBtn = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.modeloTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modeloTable
            // 
            this.modeloTable.AllowUserToAddRows = false;
            this.modeloTable.AllowUserToDeleteRows = false;
            this.modeloTable.AllowUserToOrderColumns = true;
            this.modeloTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.modeloTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeloTable.Location = new System.Drawing.Point(136, 265);
            this.modeloTable.Name = "modeloTable";
            this.modeloTable.ReadOnly = true;
            this.modeloTable.RowTemplate.Height = 24;
            this.modeloTable.Size = new System.Drawing.Size(518, 244);
            this.modeloTable.TabIndex = 11;
            this.modeloTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modeloTable_CellClick);
            // 
            // editarModeloBtn
            // 
            this.editarModeloBtn.AutoSize = true;
            this.editarModeloBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarModeloBtn.Depth = 0;
            this.editarModeloBtn.Location = new System.Drawing.Point(429, 92);
            this.editarModeloBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarModeloBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarModeloBtn.Name = "editarModeloBtn";
            this.editarModeloBtn.Primary = false;
            this.editarModeloBtn.Size = new System.Drawing.Size(145, 36);
            this.editarModeloBtn.TabIndex = 10;
            this.editarModeloBtn.Text = "Editar Modelo";
            this.editarModeloBtn.UseVisualStyleBackColor = true;
            this.editarModeloBtn.Click += new System.EventHandler(this.editarModeloBtn_Click);
            // 
            // insertModeloBtn
            // 
            this.insertModeloBtn.AutoSize = true;
            this.insertModeloBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertModeloBtn.Depth = 0;
            this.insertModeloBtn.Location = new System.Drawing.Point(142, 92);
            this.insertModeloBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertModeloBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertModeloBtn.Name = "insertModeloBtn";
            this.insertModeloBtn.Primary = false;
            this.insertModeloBtn.Size = new System.Drawing.Size(167, 36);
            this.insertModeloBtn.TabIndex = 9;
            this.insertModeloBtn.Text = "Insertar Modelo";
            this.insertModeloBtn.UseVisualStyleBackColor = true;
            this.insertModeloBtn.Click += new System.EventHandler(this.insertModeloBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 28);
            this.menuStrip1.TabIndex = 12;
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
            this.materialLabel1.Location = new System.Drawing.Point(217, 195);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Modelo";
            // 
            // modTxt
            // 
            this.modTxt.Location = new System.Drawing.Point(298, 197);
            this.modTxt.Name = "modTxt";
            this.modTxt.Size = new System.Drawing.Size(128, 22);
            this.modTxt.TabIndex = 14;
            this.modTxt.TextChanged += new System.EventHandler(this.modTxt_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(443, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 24);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Marca";
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(512, 195);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(128, 22);
            this.marcaTxt.TabIndex = 16;
            this.marcaTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // reporteBtn
            // 
            this.reporteBtn.AutoSize = true;
            this.reporteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reporteBtn.Depth = 0;
            this.reporteBtn.Location = new System.Drawing.Point(628, 92);
            this.reporteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reporteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.reporteBtn.Name = "reporteBtn";
            this.reporteBtn.Primary = false;
            this.reporteBtn.Size = new System.Drawing.Size(87, 36);
            this.reporteBtn.TabIndex = 26;
            this.reporteBtn.Text = "Reporte";
            this.reporteBtn.UseVisualStyleBackColor = true;
            this.reporteBtn.Click += new System.EventHandler(this.reporteBtn_Click);
            // 
            // ModelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 581);
            this.Controls.Add(this.reporteBtn);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.modTxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.modeloTable);
            this.Controls.Add(this.editarModeloBtn);
            this.Controls.Add(this.insertModeloBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModelosForm";
            this.Text = "Rent A Car - Modelos";
            this.Load += new System.EventHandler(this.ModelosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modeloTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modeloTable;
        private MaterialSkin.Controls.MaterialFlatButton editarModeloBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertModeloBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox modTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox marcaTxt;
        private MaterialSkin.Controls.MaterialFlatButton reporteBtn;
    }
}