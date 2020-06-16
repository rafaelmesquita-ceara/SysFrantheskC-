namespace Franthesk.View
{
    partial class cadVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadVenda));
            this.dgv_Mercadorias = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valortt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Remove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_Desconto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aa = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_ValorFinal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_ValorTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_Status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cb_Cartao = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_ID = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercadorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Mercadorias
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Mercadorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Mercadorias.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_Mercadorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Mercadorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Mercadorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Mercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mercadorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Nome,
            this.Quantidade,
            this.Valor,
            this.Valortt});
            this.dgv_Mercadorias.DoubleBuffered = true;
            this.dgv_Mercadorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Mercadorias.EnableHeadersVisualStyles = false;
            this.dgv_Mercadorias.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.dgv_Mercadorias.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgv_Mercadorias.Location = new System.Drawing.Point(12, 12);
            this.dgv_Mercadorias.Name = "dgv_Mercadorias";
            this.dgv_Mercadorias.ReadOnly = true;
            this.dgv_Mercadorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Mercadorias.Size = new System.Drawing.Size(528, 276);
            this.dgv_Mercadorias.TabIndex = 1;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referência";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 80;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 155;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtd";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor unit";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Valortt
            // 
            this.Valortt.HeaderText = "Valor total";
            this.Valortt.Name = "Valortt";
            this.Valortt.ReadOnly = true;
            // 
            // btn_Add
            // 
            this.btn_Add.ActiveBorderThickness = 1;
            this.btn_Add.ActiveCornerRadius = 20;
            this.btn_Add.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Add.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_Add.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.ButtonText = "Adicionar mercadoria";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Add.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Add.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Add.Location = new System.Drawing.Point(14, 307);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(181, 41);
            this.btn_Add.TabIndex = 73;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.ActiveBorderThickness = 1;
            this.btn_Remove.ActiveCornerRadius = 20;
            this.btn_Remove.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Remove.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_Remove.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Remove.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.ButtonText = "Remover mercadoria";
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Remove.IdleBorderThickness = 1;
            this.btn_Remove.IdleCornerRadius = 20;
            this.btn_Remove.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Remove.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Remove.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Remove.Location = new System.Drawing.Point(259, 307);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(181, 41);
            this.btn_Remove.TabIndex = 74;
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(545, 60);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 25);
            this.bunifuCustomLabel1.TabIndex = 75;
            this.bunifuCustomLabel1.Text = "Valor total:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(546, 106);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 25);
            this.bunifuCustomLabel2.TabIndex = 76;
            this.bunifuCustomLabel2.Text = "Desconto:";
            // 
            // tb_Desconto
            // 
            this.tb_Desconto.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Desconto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Desconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Desconto.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Desconto.HintText = "";
            this.tb_Desconto.isPassword = false;
            this.tb_Desconto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_Desconto.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Desconto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_Desconto.LineThickness = 3;
            this.tb_Desconto.Location = new System.Drawing.Point(666, 87);
            this.tb_Desconto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Desconto.Name = "tb_Desconto";
            this.tb_Desconto.Size = new System.Drawing.Size(80, 44);
            this.tb_Desconto.TabIndex = 102;
            this.tb_Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Desconto_KeyPress);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Finalizar venda";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(587, 307);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(130, 41);
            this.bunifuThinButton21.TabIndex = 103;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa.Location = new System.Drawing.Point(546, 155);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(104, 25);
            this.aa.TabIndex = 104;
            this.aa.Text = "Valor final:";
            // 
            // lb_ValorFinal
            // 
            this.lb_ValorFinal.AutoSize = true;
            this.lb_ValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorFinal.Location = new System.Drawing.Point(656, 155);
            this.lb_ValorFinal.Name = "lb_ValorFinal";
            this.lb_ValorFinal.Size = new System.Drawing.Size(79, 25);
            this.lb_ValorFinal.TabIndex = 105;
            this.lb_ValorFinal.Text = "R$ 0,00";
            // 
            // lb_ValorTotal
            // 
            this.lb_ValorTotal.AutoSize = true;
            this.lb_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorTotal.Location = new System.Drawing.Point(655, 60);
            this.lb_ValorTotal.Name = "lb_ValorTotal";
            this.lb_ValorTotal.Size = new System.Drawing.Size(79, 25);
            this.lb_ValorTotal.TabIndex = 106;
            this.lb_ValorTotal.Text = "R$ 0,00";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(546, 263);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(74, 25);
            this.bunifuCustomLabel6.TabIndex = 107;
            this.bunifuCustomLabel6.Text = "Status:";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.ForeColor = System.Drawing.Color.Goldenrod;
            this.lb_Status.Location = new System.Drawing.Point(629, 263);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(117, 25);
            this.lb_Status.TabIndex = 108;
            this.lb_Status.Text = "aguardando";
            // 
            // cb_Cartao
            // 
            this.cb_Cartao.AutoSize = true;
            this.cb_Cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cartao.Location = new System.Drawing.Point(656, 207);
            this.cb_Cartao.Name = "cb_Cartao";
            this.cb_Cartao.Size = new System.Drawing.Size(90, 29);
            this.cb_Cartao.TabIndex = 109;
            this.cb_Cartao.Text = "Cartão";
            this.cb_Cartao.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(547, 23);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(100, 25);
            this.bunifuCustomLabel3.TabIndex = 110;
            this.bunifuCustomLabel3.Text = "Venda n°:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(656, 23);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(23, 25);
            this.lb_ID.TabIndex = 111;
            this.lb_ID.Text = "0";
            // 
            // cadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 362);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.cb_Cartao);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.lb_ValorTotal);
            this.Controls.Add(this.lb_ValorFinal);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.tb_Desconto);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Mercadorias);
            this.Name = "cadVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadVenda";
            this.Load += new System.EventHandler(this.cadVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercadorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Mercadorias;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Remove;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Desconto;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel aa;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_ValorFinal;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_ValorTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Status;
        private System.Windows.Forms.CheckBox cb_Cartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valortt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_ID;
    }
}