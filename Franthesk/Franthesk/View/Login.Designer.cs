namespace Franthesk
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Franthesk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Login = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_Senha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Acesso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // Franthesk
            // 
            this.Franthesk.AutoSize = true;
            this.Franthesk.Font = new System.Drawing.Font("Century Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Franthesk.Location = new System.Drawing.Point(-6, 51);
            this.Franthesk.Name = "Franthesk";
            this.Franthesk.Size = new System.Drawing.Size(613, 69);
            this.Franthesk.TabIndex = 0;
            this.Franthesk.Text = "Franthesk Variedades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // tb_Login
            // 
            this.tb_Login.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.tb_Login.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Login.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.tb_Login.BorderThickness = 3;
            this.tb_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Login.isPassword = false;
            this.tb_Login.Location = new System.Drawing.Point(188, 145);
            this.tb_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(254, 44);
            this.tb_Login.TabIndex = 6;
            this.tb_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_Senha
            // 
            this.tb_Senha.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.tb_Senha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Senha.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.tb_Senha.BorderThickness = 3;
            this.tb_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Senha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Senha.isPassword = true;
            this.tb_Senha.Location = new System.Drawing.Point(188, 197);
            this.tb_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(254, 44);
            this.tb_Senha.TabIndex = 7;
            this.tb_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Acesso
            // 
            this.btn_Acesso.ActiveBorderThickness = 1;
            this.btn_Acesso.ActiveCornerRadius = 20;
            this.btn_Acesso.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btn_Acesso.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Acesso.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_Acesso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Acesso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Acesso.BackgroundImage")));
            this.btn_Acesso.ButtonText = "Acessar";
            this.btn_Acesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acesso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Acesso.IdleBorderThickness = 1;
            this.btn_Acesso.IdleCornerRadius = 20;
            this.btn_Acesso.IdleFillColor = System.Drawing.Color.White;
            this.btn_Acesso.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Acesso.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Acesso.Location = new System.Drawing.Point(208, 259);
            this.btn_Acesso.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Acesso.Name = "btn_Acesso";
            this.btn_Acesso.Size = new System.Drawing.Size(181, 41);
            this.btn_Acesso.TabIndex = 8;
            this.btn_Acesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Acesso.Click += new System.EventHandler(this.btn_Acesso_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 314);
            this.Controls.Add(this.btn_Acesso);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Franthesk);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Franthesk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_Login;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_Senha;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Acesso;
    }
}