using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Franthesk.Model;
using Franthesk.Controller;

namespace Franthesk.View
{
    public partial class consVenda : Form
    {
        public consVenda()
        {
            InitializeComponent();
        }

        private void consVenda_Load(object sender, EventArgs e)
        {
            carregarVendas();
        }
        public void carregarVendas()
        {
            dgv_Vendas.Rows.Clear();
            var venda = new Venda().retornaTodaVenda();
            foreach (var v in venda)
            {
                var cartao = "";
                if (v.CD_Cartao == 1) cartao = "Sim";
                else cartao = "Não";
                dgv_Vendas.Rows.Add(v.CD_ID, v.DT_Data, v.NM_Vendedor, v.VL_ValorTotal, cartao);

            }
        }

        private void dgv_Vendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgv_Vendas.CurrentRow.Index;
            int value = Convert.ToInt32((string)dgv_Vendas[0, i].Value.ToString());
            new consMercadoriaVenda(value).Show();
        }
    }
}
