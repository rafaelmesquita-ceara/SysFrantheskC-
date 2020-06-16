namespace Franthesk.View
{
    partial class consMercadoriaVenda
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
            this.dgv_MercadoriaVendida = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MercadoriaVendida)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MercadoriaVendida
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_MercadoriaVendida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_MercadoriaVendida.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_MercadoriaVendida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MercadoriaVendida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MercadoriaVendida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_MercadoriaVendida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MercadoriaVendida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Nome,
            this.Qtd,
            this.ValorVenda,
            this.Estoque});
            this.dgv_MercadoriaVendida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MercadoriaVendida.DoubleBuffered = true;
            this.dgv_MercadoriaVendida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_MercadoriaVendida.EnableHeadersVisualStyles = false;
            this.dgv_MercadoriaVendida.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.dgv_MercadoriaVendida.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgv_MercadoriaVendida.Location = new System.Drawing.Point(0, 0);
            this.dgv_MercadoriaVendida.Name = "dgv_MercadoriaVendida";
            this.dgv_MercadoriaVendida.ReadOnly = true;
            this.dgv_MercadoriaVendida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_MercadoriaVendida.Size = new System.Drawing.Size(509, 294);
            this.dgv_MercadoriaVendida.TabIndex = 1;
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
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 50;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor unidade";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Valor Total";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // consMercadoriaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 294);
            this.Controls.Add(this.dgv_MercadoriaVendida);
            this.Name = "consMercadoriaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consMercadoriaVenda";
            this.Load += new System.EventHandler(this.consMercadoriaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MercadoriaVendida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_MercadoriaVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
    }
}