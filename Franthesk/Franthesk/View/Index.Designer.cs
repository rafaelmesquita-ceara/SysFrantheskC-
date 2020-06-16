namespace Franthesk
{
    partial class Index
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharComissaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.mercadoriaToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.comissãoToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.mercadoriaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.cadastroToolStripMenuItem.Text = "Usuarios";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.usuarioToolStripMenuItem.Text = "Cadastrar";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // mercadoriaToolStripMenuItem
            // 
            this.mercadoriaToolStripMenuItem.Name = "mercadoriaToolStripMenuItem";
            this.mercadoriaToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.mercadoriaToolStripMenuItem.Text = "Consultar";
            // 
            // mercadoriaToolStripMenuItem1
            // 
            this.mercadoriaToolStripMenuItem1.Name = "mercadoriaToolStripMenuItem1";
            this.mercadoriaToolStripMenuItem1.Size = new System.Drawing.Size(132, 29);
            this.mercadoriaToolStripMenuItem1.Text = "Mercadorias";
            this.mercadoriaToolStripMenuItem1.Click += new System.EventHandler(this.mercadoriaToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.consultarVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.consultarToolStripMenuItem.Text = "Cadastrar Venda";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarVendaToolStripMenuItem
            // 
            this.consultarVendaToolStripMenuItem.Name = "consultarVendaToolStripMenuItem";
            this.consultarVendaToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.consultarVendaToolStripMenuItem.Text = "Consultar Venda";
            this.consultarVendaToolStripMenuItem.Click += new System.EventHandler(this.consultarVendaToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFecharToolStripMenuItem,
            this.consultarToolStripMenuItem1,
            this.movimentosToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.caixaToolStripMenuItem.Text = "Caixa";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // abrirFecharToolStripMenuItem
            // 
            this.abrirFecharToolStripMenuItem.Name = "abrirFecharToolStripMenuItem";
            this.abrirFecharToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.abrirFecharToolStripMenuItem.Text = "Abrir/Fechar";
            this.abrirFecharToolStripMenuItem.Click += new System.EventHandler(this.abrirFecharToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(192, 30);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.movimentosToolStripMenuItem.Text = "Movimentos";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // comissãoToolStripMenuItem
            // 
            this.comissãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharComissaoToolStripMenuItem,
            this.consultarToolStripMenuItem2});
            this.comissãoToolStripMenuItem.Name = "comissãoToolStripMenuItem";
            this.comissãoToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.comissãoToolStripMenuItem.Text = "Comissão";
            // 
            // fecharComissaoToolStripMenuItem
            // 
            this.fecharComissaoToolStripMenuItem.Name = "fecharComissaoToolStripMenuItem";
            this.fecharComissaoToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.fecharComissaoToolStripMenuItem.Text = "Fechar Mês";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(188, 30);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(927, 310);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharComissaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVendaToolStripMenuItem;
    }
}