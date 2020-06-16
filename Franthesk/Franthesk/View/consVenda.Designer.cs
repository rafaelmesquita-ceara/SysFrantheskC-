namespace Franthesk.View
{
    partial class consVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Vendas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Vendas
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Vendas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Nome,
            this.Categoria,
            this.ValorVenda,
            this.Estoque});
            this.dgv_Vendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Vendas.DoubleBuffered = true;
            this.dgv_Vendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Vendas.EnableHeadersVisualStyles = false;
            this.dgv_Vendas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.dgv_Vendas.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgv_Vendas.Location = new System.Drawing.Point(0, 0);
            this.dgv_Vendas.Name = "dgv_Vendas";
            this.dgv_Vendas.ReadOnly = true;
            this.dgv_Vendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Vendas.Size = new System.Drawing.Size(532, 333);
            this.dgv_Vendas.TabIndex = 3;
            this.dgv_Vendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vendas_CellDoubleClick);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "ID";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 60;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Data";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Vendedor";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 120;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Cartão";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 50;
            // 
            // consVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 333);
            this.Controls.Add(this.dgv_Vendas);
            this.Name = "consVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consVenda";
            this.Load += new System.EventHandler(this.consVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
    }
}