namespace Franthesk.View
{
    partial class cadastroMercadoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroMercadoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mercadorias = new System.Windows.Forms.TabPage();
            this.tb_Filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Mercadorias = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formulário = new System.Windows.Forms.TabPage();
            this.btn_Deletar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dd_Categoria = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Limpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_Referencia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_Nome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_Estoque = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_ValorCompra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_ValorVenda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_Lucro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_01 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabControl1.SuspendLayout();
            this.Mercadorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercadorias)).BeginInit();
            this.Formulário.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mercadorias);
            this.tabControl1.Controls.Add(this.Formulário);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 439);
            this.tabControl1.TabIndex = 49;
            // 
            // Mercadorias
            // 
            this.Mercadorias.BackColor = System.Drawing.Color.White;
            this.Mercadorias.Controls.Add(this.tb_Filtro);
            this.Mercadorias.Controls.Add(this.label1);
            this.Mercadorias.Controls.Add(this.dgv_Mercadorias);
            this.Mercadorias.Location = new System.Drawing.Point(4, 22);
            this.Mercadorias.Name = "Mercadorias";
            this.Mercadorias.Padding = new System.Windows.Forms.Padding(3);
            this.Mercadorias.Size = new System.Drawing.Size(609, 413);
            this.Mercadorias.TabIndex = 0;
            this.Mercadorias.Text = "Mercadorias";
            // 
            // tb_Filtro
            // 
            this.tb_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Filtro.Location = new System.Drawing.Point(111, 3);
            this.tb_Filtro.Name = "tb_Filtro";
            this.tb_Filtro.Size = new System.Drawing.Size(491, 26);
            this.tb_Filtro.TabIndex = 2;
            this.tb_Filtro.TextChanged += new System.EventHandler(this.tb_Filtro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa:";
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
            this.Categoria,
            this.ValorVenda,
            this.Estoque});
            this.dgv_Mercadorias.DoubleBuffered = true;
            this.dgv_Mercadorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Mercadorias.EnableHeadersVisualStyles = false;
            this.dgv_Mercadorias.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.dgv_Mercadorias.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgv_Mercadorias.Location = new System.Drawing.Point(3, 31);
            this.dgv_Mercadorias.Name = "dgv_Mercadorias";
            this.dgv_Mercadorias.ReadOnly = true;
            this.dgv_Mercadorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Mercadorias.Size = new System.Drawing.Size(603, 379);
            this.dgv_Mercadorias.TabIndex = 0;
            this.dgv_Mercadorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mercadorias_CellClick);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referência";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 90;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor de venda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // Formulário
            // 
            this.Formulário.BackColor = System.Drawing.Color.White;
            this.Formulário.Controls.Add(this.btn_Deletar);
            this.Formulário.Controls.Add(this.dd_Categoria);
            this.Formulário.Controls.Add(this.bunifuCustomLabel9);
            this.Formulário.Controls.Add(this.btn_Enviar);
            this.Formulário.Controls.Add(this.btn_Limpar);
            this.Formulário.Controls.Add(this.bunifuCustomLabel4);
            this.Formulário.Controls.Add(this.tb_Referencia);
            this.Formulário.Controls.Add(this.tb_Nome);
            this.Formulário.Controls.Add(this.tb_Estoque);
            this.Formulário.Controls.Add(this.tb_ValorCompra);
            this.Formulário.Controls.Add(this.bunifuCustomLabel8);
            this.Formulário.Controls.Add(this.bunifuCustomLabel1);
            this.Formulário.Controls.Add(this.tb_ValorVenda);
            this.Formulário.Controls.Add(this.bunifuCustomLabel2);
            this.Formulário.Controls.Add(this.bunifuCustomLabel6);
            this.Formulário.Controls.Add(this.bunifuCustomLabel3);
            this.Formulário.Controls.Add(this.tb_Lucro);
            this.Formulário.Controls.Add(this.bunifuCustomLabel5);
            this.Formulário.Controls.Add(this.lb_01);
            this.Formulário.Location = new System.Drawing.Point(4, 22);
            this.Formulário.Name = "Formulário";
            this.Formulário.Padding = new System.Windows.Forms.Padding(3);
            this.Formulário.Size = new System.Drawing.Size(609, 413);
            this.Formulário.TabIndex = 1;
            this.Formulário.Text = "Formulário";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.ActiveBorderThickness = 1;
            this.btn_Deletar.ActiveCornerRadius = 20;
            this.btn_Deletar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Deletar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Deletar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Deletar.BackColor = System.Drawing.Color.White;
            this.btn_Deletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Deletar.BackgroundImage")));
            this.btn_Deletar.ButtonText = "Deletar";
            this.btn_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Deletar.IdleBorderThickness = 1;
            this.btn_Deletar.IdleCornerRadius = 20;
            this.btn_Deletar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Deletar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deletar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deletar.Location = new System.Drawing.Point(60, 346);
            this.btn_Deletar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(131, 41);
            this.btn_Deletar.TabIndex = 108;
            this.btn_Deletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // dd_Categoria
            // 
            this.dd_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd_Categoria.FormattingEnabled = true;
            this.dd_Categoria.Location = new System.Drawing.Point(175, 142);
            this.dd_Categoria.Name = "dd_Categoria";
            this.dd_Categoria.Size = new System.Drawing.Size(275, 23);
            this.dd_Categoria.TabIndex = 103;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(456, 138);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(67, 32);
            this.bunifuCustomLabel9.TabIndex = 83;
            this.bunifuCustomLabel9.Text = "Criar\r\nCategoria";
            this.bunifuCustomLabel9.Click += new System.EventHandler(this.bunifuCustomLabel9_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.ActiveBorderThickness = 1;
            this.btn_Enviar.ActiveCornerRadius = 20;
            this.btn_Enviar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Enviar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Enviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Enviar.BackColor = System.Drawing.Color.White;
            this.btn_Enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Enviar.BackgroundImage")));
            this.btn_Enviar.ButtonText = "Cadastrar";
            this.btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Enviar.IdleBorderThickness = 1;
            this.btn_Enviar.IdleCornerRadius = 20;
            this.btn_Enviar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Enviar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Enviar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Enviar.Location = new System.Drawing.Point(392, 346);
            this.btn_Enviar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(131, 41);
            this.btn_Enviar.TabIndex = 71;
            this.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.ActiveBorderThickness = 1;
            this.btn_Limpar.ActiveCornerRadius = 20;
            this.btn_Limpar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Limpar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Limpar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Limpar.BackColor = System.Drawing.Color.White;
            this.btn_Limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.BackgroundImage")));
            this.btn_Limpar.ButtonText = "Limpar";
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Limpar.IdleBorderThickness = 1;
            this.btn_Limpar.IdleCornerRadius = 20;
            this.btn_Limpar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Limpar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Limpar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Limpar.Location = new System.Drawing.Point(231, 346);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(131, 41);
            this.btn_Limpar.TabIndex = 78;
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(316, 199);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(68, 50);
            this.bunifuCustomLabel4.TabIndex = 79;
            this.bunifuCustomLabel4.Text = "Lucro \r\nem %:";
            // 
            // tb_Referencia
            // 
            this.tb_Referencia.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Referencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Referencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Referencia.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Referencia.HintText = "";
            this.tb_Referencia.isPassword = false;
            this.tb_Referencia.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_Referencia.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Referencia.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_Referencia.LineThickness = 3;
            this.tb_Referencia.Location = new System.Drawing.Point(182, 63);
            this.tb_Referencia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Referencia.Name = "tb_Referencia";
            this.tb_Referencia.Size = new System.Drawing.Size(82, 44);
            this.tb_Referencia.TabIndex = 101;
            this.tb_Referencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Referencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Referencia_KeyPress);
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.SystemColors.Control;
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
            this.tb_Nome.Location = new System.Drawing.Point(364, 63);
            this.tb_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(157, 44);
            this.tb_Nome.TabIndex = 102;
            this.tb_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_Estoque
            // 
            this.tb_Estoque.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Estoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Estoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Estoque.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Estoque.HintText = "";
            this.tb_Estoque.isPassword = false;
            this.tb_Estoque.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_Estoque.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Estoque.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_Estoque.LineThickness = 3;
            this.tb_Estoque.Location = new System.Drawing.Point(416, 262);
            this.tb_Estoque.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Estoque.Name = "tb_Estoque";
            this.tb_Estoque.Size = new System.Drawing.Size(105, 44);
            this.tb_Estoque.TabIndex = 107;
            this.tb_Estoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Estoque_KeyPress);
            // 
            // tb_ValorCompra
            // 
            this.tb_ValorCompra.BackColor = System.Drawing.SystemColors.Control;
            this.tb_ValorCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_ValorCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ValorCompra.HintForeColor = System.Drawing.Color.Empty;
            this.tb_ValorCompra.HintText = "";
            this.tb_ValorCompra.isPassword = false;
            this.tb_ValorCompra.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_ValorCompra.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_ValorCompra.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_ValorCompra.LineThickness = 3;
            this.tb_ValorCompra.Location = new System.Drawing.Point(163, 188);
            this.tb_ValorCompra.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ValorCompra.Name = "tb_ValorCompra";
            this.tb_ValorCompra.Size = new System.Drawing.Size(133, 44);
            this.tb_ValorCompra.TabIndex = 104;
            this.tb_ValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(316, 272);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(90, 25);
            this.bunifuCustomLabel8.TabIndex = 82;
            this.bunifuCustomLabel8.Text = "Estoque:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(55, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 25);
            this.bunifuCustomLabel1.TabIndex = 73;
            this.bunifuCustomLabel1.Text = "Referencia:";
            // 
            // tb_ValorVenda
            // 
            this.tb_ValorVenda.BackColor = System.Drawing.SystemColors.Control;
            this.tb_ValorVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_ValorVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ValorVenda.HintForeColor = System.Drawing.Color.Empty;
            this.tb_ValorVenda.HintText = "";
            this.tb_ValorVenda.isPassword = false;
            this.tb_ValorVenda.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_ValorVenda.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_ValorVenda.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_ValorVenda.LineThickness = 3;
            this.tb_ValorVenda.Location = new System.Drawing.Point(163, 262);
            this.tb_ValorVenda.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ValorVenda.Name = "tb_ValorVenda";
            this.tb_ValorVenda.Size = new System.Drawing.Size(133, 44);
            this.tb_ValorVenda.TabIndex = 106;
            this.tb_ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ValorVenda_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(282, 75);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 25);
            this.bunifuCustomLabel2.TabIndex = 74;
            this.bunifuCustomLabel2.Text = "Nome:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(55, 272);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 50);
            this.bunifuCustomLabel6.TabIndex = 80;
            this.bunifuCustomLabel6.Text = "Valor na \rvenda:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(55, 138);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(103, 25);
            this.bunifuCustomLabel3.TabIndex = 75;
            this.bunifuCustomLabel3.Text = "Categoria:";
            // 
            // tb_Lucro
            // 
            this.tb_Lucro.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Lucro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_Lucro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Lucro.HintForeColor = System.Drawing.Color.Empty;
            this.tb_Lucro.HintText = "";
            this.tb_Lucro.isPassword = false;
            this.tb_Lucro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tb_Lucro.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_Lucro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.tb_Lucro.LineThickness = 3;
            this.tb_Lucro.Location = new System.Drawing.Point(392, 188);
            this.tb_Lucro.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Lucro.Name = "tb_Lucro";
            this.tb_Lucro.Size = new System.Drawing.Size(129, 44);
            this.tb_Lucro.TabIndex = 105;
            this.tb_Lucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Lucro.OnValueChanged += new System.EventHandler(this.tb_Lucro_OnValueChanged);
            this.tb_Lucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Lucro_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(55, 199);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(90, 50);
            this.bunifuCustomLabel5.TabIndex = 76;
            this.bunifuCustomLabel5.Text = "Valor na \r\ncompra:";
            // 
            // lb_01
            // 
            this.lb_01.AutoSize = true;
            this.lb_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_01.Location = new System.Drawing.Point(82, 10);
            this.lb_01.Name = "lb_01";
            this.lb_01.Size = new System.Drawing.Size(405, 46);
            this.lb_01.TabIndex = 77;
            this.lb_01.Text = "Cadastrar mercadoria";
            // 
            // cadastroMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 440);
            this.Controls.Add(this.tabControl1);
            this.Name = "cadastroMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastroMercadoria";
            this.Load += new System.EventHandler(this.cadastroMercadoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.Mercadorias.ResumeLayout(false);
            this.Mercadorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercadorias)).EndInit();
            this.Formulário.ResumeLayout(false);
            this.Formulário.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Mercadorias;
        private System.Windows.Forms.TabPage Formulário;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Enviar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Limpar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Referencia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Nome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Estoque;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_ValorCompra;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_ValorVenda;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Lucro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Mercadorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_01;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox dd_Categoria;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Deletar;
        private System.Windows.Forms.TextBox tb_Filtro;
        private System.Windows.Forms.Label label1;
    }
}