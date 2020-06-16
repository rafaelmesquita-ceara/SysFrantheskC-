using Franthesk.Controller;
using Franthesk.Model;
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
    public partial class cadVenda : Form
    {
        public cadVenda()
        {
            InitializeComponent();
        }

        int contagemLinhas = 0;
        double valorVenda = 0;
        double valorFinal = 0;
        double valorDesconto = 0;
        int[] numeros = new int[20];

        private void btn_Add_Click(object sender, EventArgs e)
        {
            cadVenda_Mercadoria adicionarMercadoria  = new cadVenda_Mercadoria();
            adicionarMercadoria.ShowDialog();
            int referencia = adicionarMercadoria.Retorno;
            int quantidade = adicionarMercadoria.Qtd;
            if (referencia != 0) {
                var m = new Mercadoria().retornaMercadoria(referencia);
                dgv_Mercadorias.Rows.Add(m.CD_Referencia, m.NM_Nome, quantidade, m.VL_ValorVenda, m.VL_ValorVenda*quantidade);
                double valorMercadoria = Convert.ToDouble(dgv_Mercadorias[4, contagemLinhas].Value);
                valorVenda += valorMercadoria;
                atualizaValores();
                contagemLinhas++;
            }
            
        }

        private void cadVenda_Load(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            int idVenda = new Venda().idUltimaVenda();
            lb_ID.Text = idVenda.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgv_Mercadorias.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    double valorMercadoria = Convert.ToDouble(dgv_Mercadorias[4, oneCell.RowIndex].Value);
                    valorVenda -= valorMercadoria;
                    atualizaValores();
                    contagemLinhas--;
                    dgv_Mercadorias.Rows.RemoveAt(oneCell.RowIndex);
                   
                }
            }
        }

        private void atualizaValores()
        {
            valorFinal = valorVenda - valorDesconto;
            lb_ValorTotal.Text = valorVenda.ToString("C");
            lb_ValorFinal.Text = valorFinal.ToString("C");
        }

        private void tb_Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tb_Desconto.Text != "")
                {
                    valorDesconto = Convert.ToDouble(tb_Desconto.Text);
                    atualizaValores();
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(new Caixa().caixaAberto() != null)
            {
                lb_Status.ForeColor = Color.FromArgb(0, 128, 128);
                lb_Status.Text = "processando";
                MessageBox.Show(dgv_Mercadorias.RowCount.ToString());
                // ---------------------------------------------------------
                DateTime dataAgora = DateTime.Now;
                VENDA venda = new VENDA();
                venda.NM_Vendedor = "Rafael";
                venda.DT_Data = dataAgora.ToString("dd/MM/yyyy HH:mm:ss");
                venda.VL_ValorTotal = valorFinal;
                venda.CD_ID = Convert.ToInt32(lb_ID.Text);
                venda.CD_Cartao = cb_Cartao.Checked ? 1 : 0;
                new Venda().cadastraVenda(venda);

                lb_Status.Text = "venda criada";
                // ---------------------------------------------------------
                for (int i = 0; i < dgv_Mercadorias.RowCount-1; i++)
                {
                    int qtd = Convert.ToInt32(dgv_Mercadorias[2, i].Value);
                    int referencia = Convert.ToInt32(dgv_Mercadorias[0, i].Value);
                    MERCADORIA_VENDA mercadoria = new MERCADORIA_VENDA();
                    mercadoria.CD_Mercadoria = Convert.ToInt32(dgv_Mercadorias[0, i].Value);
                    mercadoria.CD_Venda = Convert.ToInt32(lb_ID.Text);
                    mercadoria.QT_Quantidade = Convert.ToInt32(dgv_Mercadorias[2, i].Value);
                    new Venda().cadastraMercadoriaVendida(mercadoria);
                    MERCADORIA mercadoria_alterada = new Mercadoria().retornaMercadoria(referencia);
                    mercadoria_alterada.VL_Estoque -= qtd;
                    new Mercadoria().alteraMercadoria(mercadoria_alterada);

                    lb_Status.Text = "mercadoria " + i + " OK";
                }
                // ---------------------------------------------------------
                var caixa = new Caixa().caixaAberto();
                if(cb_Cartao.Checked)
                {
                    caixa.VL_ValorCartaoAdmin += valorFinal;
                }
                else
                {
                    caixa.VL_ValorDinheiroAdmin += valorFinal;
                }
                new Caixa().AlteraCaixa(caixa);
                lb_Status.Text = "inserida no caixa";
                // ---------------------------------------------------------
                lb_Status.Text = "Finalizada";
                lb_Status.ForeColor = Color.YellowGreen;
            }
            else
            {
                MessageBox.Show("Erro: Caixa deve estar aberto para realizar a venda");
            }
            
        }
    }
}
