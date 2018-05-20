namespace RentACar
{
    partial class TipoCombustibleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoCombustibleForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCTable = new System.Windows.Forms.DataGridView();
            this.editarTcBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertTcBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tcText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.atrásToolStripMenuItem.Text = "atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // TCTable
            // 
            this.TCTable.AllowUserToAddRows = false;
            this.TCTable.AllowUserToDeleteRows = false;
            this.TCTable.AllowUserToOrderColumns = true;
            this.TCTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TCTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TCTable.Location = new System.Drawing.Point(210, 277);
            this.TCTable.Name = "TCTable";
            this.TCTable.ReadOnly = true;
            this.TCTable.RowTemplate.Height = 24;
            this.TCTable.Size = new System.Drawing.Size(440, 224);
            this.TCTable.TabIndex = 11;
            this.TCTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TCTable_CellClick);
            // 
            // editarTcBtn
            // 
            this.editarTcBtn.AutoSize = true;
            this.editarTcBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarTcBtn.Depth = 0;
            this.editarTcBtn.Location = new System.Drawing.Point(473, 97);
            this.editarTcBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarTcBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarTcBtn.Name = "editarTcBtn";
            this.editarTcBtn.Primary = false;
            this.editarTcBtn.Size = new System.Drawing.Size(234, 36);
            this.editarTcBtn.TabIndex = 10;
            this.editarTcBtn.Text = "Editar Tipo Combustible";
            this.editarTcBtn.UseVisualStyleBackColor = true;
            this.editarTcBtn.Click += new System.EventHandler(this.editarTcBtn_Click);
            // 
            // insertTcBtn
            // 
            this.insertTcBtn.AutoSize = true;
            this.insertTcBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertTcBtn.Depth = 0;
            this.insertTcBtn.Location = new System.Drawing.Point(142, 97);
            this.insertTcBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertTcBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertTcBtn.Name = "insertTcBtn";
            this.insertTcBtn.Primary = false;
            this.insertTcBtn.Size = new System.Drawing.Size(256, 36);
            this.insertTcBtn.TabIndex = 9;
            this.insertTcBtn.Text = "Insertar Tipo Combustible";
            this.insertTcBtn.UseVisualStyleBackColor = true;
            this.insertTcBtn.Click += new System.EventHandler(this.insertTcBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(206, 203);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Tipo Combustible";
            // 
            // tcText
            // 
            this.tcText.Location = new System.Drawing.Point(373, 205);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(227, 22);
            this.tcText.TabIndex = 13;
            this.tcText.TextChanged += new System.EventHandler(this.tcText_TextChanged);
            // 
            // TipoCombustibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 599);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TCTable);
            this.Controls.Add(this.editarTcBtn);
            this.Controls.Add(this.insertTcBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TipoCombustibleForm";
            this.Text = "Rent A Car - Tipo Combustible";
            this.Load += new System.EventHandler(this.TipoCombustibleForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.DataGridView TCTable;
        private MaterialSkin.Controls.MaterialFlatButton editarTcBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertTcBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox tcText;
    }
}