namespace RentACar
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userTxt = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(359, 192);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(198, 22);
            this.userTxt.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(248, 190);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Usuario";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(359, 234);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(198, 22);
            this.passTxt.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(216, 232);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(359, 289);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(172, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Depth = 0;
            this.errLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.errLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errLabel.Location = new System.Drawing.Point(359, 136);
            this.errLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 24);
            this.errLabel.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 476);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.userTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Rent A Car - Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox passTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel errLabel;
    }
}

