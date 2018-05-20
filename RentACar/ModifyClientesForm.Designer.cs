namespace RentACar
{
    partial class ModifyClientesForm
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
            this.estadoCbx = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.tipoPCbx = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.nmTarTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.cedTxt = new System.Windows.Forms.TextBox();
            this.enviarClBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lmCrdTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estadoCbx
            // 
            this.estadoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCbx.FormattingEnabled = true;
            this.estadoCbx.Location = new System.Drawing.Point(358, 427);
            this.estadoCbx.Name = "estadoCbx";
            this.estadoCbx.Size = new System.Drawing.Size(162, 24);
            this.estadoCbx.TabIndex = 34;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(177, 425);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 24);
            this.materialLabel8.TabIndex = 33;
            this.materialLabel8.Text = "Estado";
            // 
            // tipoPCbx
            // 
            this.tipoPCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPCbx.FormattingEnabled = true;
            this.tipoPCbx.Items.AddRange(new object[] {
            "Juridica",
            "Fisica"});
            this.tipoPCbx.Location = new System.Drawing.Point(358, 376);
            this.tipoPCbx.Name = "tipoPCbx";
            this.tipoPCbx.Size = new System.Drawing.Size(162, 24);
            this.tipoPCbx.TabIndex = 32;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(171, 374);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(122, 24);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Tipo Persona";
            // 
            // nmTarTxt
            // 
            this.nmTarTxt.Location = new System.Drawing.Point(358, 275);
            this.nmTarTxt.MaxLength = 13;
            this.nmTarTxt.Name = "nmTarTxt";
            this.nmTarTxt.Size = new System.Drawing.Size(162, 22);
            this.nmTarTxt.TabIndex = 29;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(358, 232);
            this.nombreTxt.MaxLength = 5000;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(162, 22);
            this.nombreTxt.TabIndex = 28;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(358, 184);
            this.passTxt.MaxLength = 5000;
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(162, 22);
            this.passTxt.TabIndex = 27;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(358, 140);
            this.emailTxt.MaxLength = 5000;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(162, 22);
            this.emailTxt.TabIndex = 26;
            // 
            // cedTxt
            // 
            this.cedTxt.Location = new System.Drawing.Point(358, 95);
            this.cedTxt.MaxLength = 11;
            this.cedTxt.Name = "cedTxt";
            this.cedTxt.Size = new System.Drawing.Size(162, 22);
            this.cedTxt.TabIndex = 25;
            // 
            // enviarClBtn
            // 
            this.enviarClBtn.AutoSize = true;
            this.enviarClBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enviarClBtn.Depth = 0;
            this.enviarClBtn.Location = new System.Drawing.Point(315, 477);
            this.enviarClBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enviarClBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.enviarClBtn.Name = "enviarClBtn";
            this.enviarClBtn.Primary = false;
            this.enviarClBtn.Size = new System.Drawing.Size(106, 36);
            this.enviarClBtn.TabIndex = 24;
            this.enviarClBtn.Text = "EnviarBtn";
            this.enviarClBtn.UseVisualStyleBackColor = true;
            this.enviarClBtn.Click += new System.EventHandler(this.enviarClBtn_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(171, 322);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 24);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = "Limite Credito";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(171, 273);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(141, 24);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Numero Tarjeta";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(171, 232);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 24);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(171, 184);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 24);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Contraseña";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(171, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 24);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Email";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(171, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 24);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Cedula";
            // 
            // lmCrdTxt
            // 
            this.lmCrdTxt.Location = new System.Drawing.Point(358, 324);
            this.lmCrdTxt.MaxLength = 5000;
            this.lmCrdTxt.Name = "lmCrdTxt";
            this.lmCrdTxt.Size = new System.Drawing.Size(162, 22);
            this.lmCrdTxt.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.atrasToolStripMenuItem.Text = "atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // ModifyClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 555);
            this.Controls.Add(this.lmCrdTxt);
            this.Controls.Add(this.estadoCbx);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.tipoPCbx);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.nmTarTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.cedTxt);
            this.Controls.Add(this.enviarClBtn);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModifyClientesForm";
            this.Text = "Rent A Car -";
            this.Load += new System.EventHandler(this.ModifyClientesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox estadoCbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ComboBox tipoPCbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox nmTarTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox cedTxt;
        private MaterialSkin.Controls.MaterialFlatButton enviarClBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox lmCrdTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
    }
}