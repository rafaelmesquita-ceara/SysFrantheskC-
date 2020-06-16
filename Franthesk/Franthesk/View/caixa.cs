using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Franthesk.Controller;
using Franthesk.Model;

namespace Franthesk.View
{
    public partial class caixa : Form
    {
        public caixa()
        {
            InitializeComponent();
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            carregamento();

        }
        
        private void carregamento()
        {
            lb_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            var caixa = new Caixa().caixaAberto();
            if (caixa != null)
            {
                lb_Status.Text = ("Aberto");
                lb_Status.ForeColor = System.Drawing.Color.YellowGreen;
                lb_Inicial.Text = "R$ " + caixa.VL_ValorInicial;
                var total = caixa.VL_ValorCartaoAdmin + caixa.VL_ValorCartaoFunc + caixa.VL_ValorDinheiroAdmin + caixa.VL_ValorDinheiroFunc;
                lb_Atual.Text = "R$ " + (total + caixa.VL_ValorInicial);
                btn_abrirFecharCaixa.ButtonText = "Fechar caixa";
                tb_Inicial.Visible = false;
            }
            else
            {
                lb_Status.Text = ("Fechado");
                lb_Status.ForeColor = System.Drawing.Color.Firebrick;
                lb_Inicial.Text = "R$ 00,00";
                lb_Atual.Text = "R$ 00,00";
                btn_abrirFecharCaixa.ButtonText = "Abrir caixa";
                tb_Inicial.Visible = true;
            }
        }

        private void btn_abrirFecharCaixa_Click(object sender, EventArgs e)
        {
            if (lb_Status.Text == "Fechado")
            {
                CAIXA caixa = new CAIXA();
                caixa.DT_Data = DateTime.Now.ToString("dd/MM/yyyy");
                caixa.NM_Status = "aberto";
                caixa.VL_ValorCartaoAdmin = 0;
                caixa.VL_ValorCartaoFunc = 0;
                caixa.VL_ValorDinheiroAdmin = 0;
                caixa.VL_ValorDinheiroFunc = 0;
                caixa.VL_ValorInicial = Convert.ToDouble(tb_Inicial.Text);
                new Caixa().abreCaixa(caixa);
                carregamento();
            }
            else
            {
                var caixa = new Caixa().caixaAberto();
                caixa.NM_Status = "fechado";
                new Caixa().AlteraCaixa(caixa);
                carregamento();
            }
        }

    }
}
