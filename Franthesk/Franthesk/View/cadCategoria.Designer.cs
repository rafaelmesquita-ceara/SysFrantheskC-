namespace Franthesk.View
{
    partial class cadCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCategoria));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_Nome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(70, 25);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Nome:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Nome.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Nome.HintText = "";
            this.tb_Nome.isPassword = false;
            this.tb_Nome.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_Nome.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Nome.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_Nome.LineThickness = 3;
            this.tb_Nome.Location = new System.Drawing.Point(89, 47);
            this.tb_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(140, 44);
            this.tb_Nome.TabIndex = 7;
            this.tb_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.ActiveBorderThickness = 1;
            this.btn_Enviar.ActiveCornerRadius = 20;
            this.btn_Enviar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Enviar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_Enviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Enviar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Enviar.BackgroundImage")));
            this.btn_Enviar.ButtonText = "Cadastrar";
            this.btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Enviar.IdleBorderThickness = 1;
            this.btn_Enviar.IdleCornerRadius = 20;
            this.btn_Enviar.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Enviar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Enviar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Enviar.Location = new System.Drawing.Point(36, 124);
            this.btn_Enviar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(181, 41);
            this.btn_Enviar.TabIndex = 72;
            this.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // cadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 191);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tb_Nome);
            this.Name = "cadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Nome;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Enviar;
    }
}