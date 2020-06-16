using Franthesk.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franthesk.View
{
    public partial class cadVenda_Mercadoria : Form
    {
        public cadVenda_Mercadoria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            carregaMercadoriaFiltro();
        }

        private void cadVenda_Mercadoria_Load(object sender, EventArgs e)
        {
            carregarMercadorias();
        }

        public void carregaMercadoriaFiltro()
        {
            dgv_Mercadorias.Rows.Clear();
            var mercadoria = new Mercadoria().retornaMercadoriaPorNome(tb_Filtro.Text);
            foreach (var m in mercadoria)
            {
                dgv_Mercadorias.Rows.Add(m.CD_Referencia, m.NM_Nome, m.TG_Categoria, m.VL_ValorVenda, m.VL_Estoque);

            }

        }


        public void carregarMercadorias()
        {
            dgv_Mercadorias.Rows.Clear();
            var mercadoria = new Mercadoria().retornaTodaMercadoria();
            foreach (var m in mercadoria)
            {
                dgv_Mercadorias.Rows.Add(m.CD_Referencia, m.NM_Nome, m.TG_Categoria, m.VL_ValorVenda, m.VL_Estoque);

            }
        }

        public void dgv_Mercadorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgv_Mercadorias.CurrentRow.Index;
            int value = Convert.ToInt32((string)dgv_Mercadorias[0, i].Value.ToString());
            Retorno = value;
            Qtd = Convert.ToInt32(tb_qtd.Text);
            this.Close();
        }
        public int Retorno { get; set; }
        public int Qtd { get; set; }

        private void dgv_Mercadorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
