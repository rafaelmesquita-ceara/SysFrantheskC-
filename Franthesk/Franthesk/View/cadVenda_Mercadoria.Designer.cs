namespace Franthesk.View
{
    partial class cadVenda_Mercadoria
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
            this.tb_Filtro = new System.Windows.Forms.TextBox();
            this.dgv_Mercadorias = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_qtd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercadorias)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Filtro
            // 
            this.tb_Filtro.Location = new System.Drawing.Point(80, 6);
            this.tb_Filtro.Name = "tb_Filtro";
            this.tb_Filtro.Size = new System.Drawing.Size(364, 20);
            this.tb_Filtro.TabIndex = 0;
            this.tb_Filtro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.dgv_Mercadorias.Location = new System.Drawing.Point(3, 32);
            this.dgv_Mercadorias.Name = "dgv_Mercadorias";
            this.dgv_Mercadorias.ReadOnly = true;
            this.dgv_Mercadorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Mercadorias.Size = new System.Drawing.Size(608, 309);
            this.dgv_Mercadorias.TabIndex = 1;
            this.dgv_Mercadorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mercadorias_CellContentClick);
            this.dgv_Mercadorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mercadorias_CellDoubleClick);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referência";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 175;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 120;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            // 
            // tb_qtd
            // 
            this.tb_qtd.Location = new System.Drawing.Point(521, 6);
            this.tb_qtd.Name = "tb_qtd";
            this.tb_qtd.Size = new System.Drawing.Size(90, 20);
            this.tb_qtd.TabIndex = 4;
            this.tb_qtd.Text = "1";
            // 
            // cadVenda_Mercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 344);
            this.Controls.Add(this.tb_qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Mercadorias);
            this.Controls.Add(this.tb_Filtro);
            this.Name = "cadVenda_Mercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar mercadoria";
            this.Load += new System.EventHandler(this.cadVenda_Mercadoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercadorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Filtro;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Mercadorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_qtd;
    }
}