namespace RentACar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.tpVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.marcasBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiculoBtn
            // 
            this.vehiculoBtn.AutoSize = true;
            this.vehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vehiculoBtn.Depth = 0;
            this.vehiculoBtn.Location = new System.Drawing.Point(96, 141);
            this.vehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.vehiculoBtn.Name = "vehiculoBtn";
            this.vehiculoBtn.Primary = false;
            this.vehiculoBtn.Size = new System.Drawing.Size(105, 36);
            this.vehiculoBtn.TabIndex = 0;
            this.vehiculoBtn.Text = "Vehiculos";
            this.vehiculoBtn.UseVisualStyleBackColor = true;
            this.vehiculoBtn.Click += new System.EventHandler(this.vehiculoBtn_Click);
            // 
            // tpVehiculoBtn
            // 
            this.tpVehiculoBtn.AutoSize = true;
            this.tpVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpVehiculoBtn.Depth = 0;
            this.tpVehiculoBtn.Location = new System.Drawing.Point(244, 141);
            this.tpVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tpVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpVehiculoBtn.Name = "tpVehiculoBtn";
            this.tpVehiculoBtn.Primary = false;
            this.tpVehiculoBtn.Size = new System.Drawing.Size(147, 36);
            this.tpVehiculoBtn.TabIndex = 1;
            this.tpVehiculoBtn.Text = "Tipo Vehiculos";
            this.tpVehiculoBtn.UseVisualStyleBackColor = true;
            this.tpVehiculoBtn.Click += new System.EventHandler(this.tpVehiculoBtn_Click);
            // 
            // marcasBtn
            // 
            this.marcasBtn.AutoSize = true;
            this.marcasBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.marcasBtn.Depth = 0;
            this.marcasBtn.Location = new System.Drawing.Point(429, 141);
            this.marcasBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.marcasBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.marcasBtn.Name = "marcasBtn";
            this.marcasBtn.Primary = false;
            this.marcasBtn.Size = new System.Drawing.Size(83, 36);
            this.marcasBtn.TabIndex = 2;
            this.marcasBtn.Text = "Marcas";
            this.marcasBtn.UseVisualStyleBackColor = true;
            this.marcasBtn.Click += new System.EventHandler(this.marcasBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // modelosBtn
            // 
            this.modelosBtn.AutoSize = true;
            this.modelosBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modelosBtn.Depth = 0;
            this.modelosBtn.Location = new System.Drawing.Point(96, 209);
            this.modelosBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.modelosBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.modelosBtn.Name = "modelosBtn";
            this.modelosBtn.Primary = false;
            this.modelosBtn.Size = new System.Drawing.Size(92, 36);
            this.modelosBtn.TabIndex = 4;
            this.modelosBtn.Text = "Modelos";
            this.modelosBtn.UseVisualStyleBackColor = true;
            this.modelosBtn.Click += new System.EventHandler(this.modelosBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 449);
            this.Controls.Add(this.modelosBtn);
            this.Controls.Add(this.marcasBtn);
            this.Controls.Add(this.tpVehiculoBtn);
            this.Controls.Add(this.vehiculoBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Rent a Car - Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton vehiculoBtn;
        private MaterialSkin.Controls.MaterialFlatButton tpVehiculoBtn;
        private MaterialSkin.Controls.MaterialFlatButton marcasBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton modelosBtn;
    }
}