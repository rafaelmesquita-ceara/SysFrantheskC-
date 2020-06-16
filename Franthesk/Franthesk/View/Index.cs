using Franthesk.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franthesk
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cadUsu().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cadastroMercadoria().Show();
        }

        private void mercadoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new cadastroMercadoria().Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cadVenda().Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirFecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new caixa().Show();
        }

        private void consultarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
        }

        private void vAISEFUDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new consVenda().Show();
        }

        private void consultarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new consVenda().Show();
        }
    }
}
