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
    public partial class consMercadoriaVenda : Form
    {
        int idGlobal = 0;
        public consMercadoriaVenda(int id)
        {
            idGlobal = id;
            InitializeComponent();
        }

        private void consMercadoriaVenda_Load(object sender, EventArgs e)
        {
            dgv_MercadoriaVendida.Rows.Clear();
            var Mercvenda = new Venda().retornaMercadoriaVendida(idGlobal);
            foreach (var v in Mercvenda)
            {
                var mercadoria = new Mercadoria().retornaMercadoria(Convert.ToInt32(v.CD_Mercadoria));

                dgv_MercadoriaVendida.Rows.Add(mercadoria.CD_Referencia, mercadoria.NM_Nome, v.QT_Quantidade, mercadoria.VL_ValorVenda, v.QT_Quantidade*mercadoria.VL_ValorVenda);

            }
        }
    }
}
