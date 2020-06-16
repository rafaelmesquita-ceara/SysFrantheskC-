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
using Franthesk.Controller;
using System.IO;

namespace Franthesk.View
{
    public partial class cadastroMercadoria : Form
    {
        public cadastroMercadoria()
        {
            InitializeComponent();
        }

       

        private void cadastroMercadoria_Load(object sender, EventArgs e)
        {
            carregarCategorias();
            
        }



        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            if (tb_Referencia.Text == "" || tb_Nome.Text == "" || dd_Categoria.Text == "Selecione:" ||
                tb_ValorCompra.Text == "" || tb_ValorVenda.Text == "" || tb_Estoque.Text == "")
            {
                MessageBox.Show("Ocorreu um erro na verificação do formulário\n -Preencha todos os campos", "Erro ao cadastrar");
            }
            else {
                try {
                    bool mercadoriaExistente = new Mercadoria().mercadoriaExistente(Convert.ToInt32(tb_Referencia.Text));
                    if (mercadoriaExistente)
                    {
                        var mercadoria = new Mercadoria().retornaMercadoria(Convert.ToInt32(tb_Referencia.Text));
                        mercadoria.NM_Nome = tb_Nome.Text;
                        mercadoria.TG_Categoria = dd_Categoria.Text;
                        mercadoria.VL_ValorCompra = Convert.ToDouble(tb_ValorCompra.Text);
                        mercadoria.VL_ValorVenda = Convert.ToDouble(tb_ValorVenda.Text);
                        mercadoria.VL_Estoque = Convert.ToInt32(tb_Estoque.Text);
                        new Mercadoria().alteraMercadoria(mercadoria);
                    }
                    else
                    {
                        DateTime dataAgora = DateTime.Now;
                        MERCADORIA mercadoria = new MERCADORIA();
                        mercadoria.CD_Referencia = Convert.ToInt32(tb_Referencia.Text);
                        mercadoria.NM_Nome = tb_Nome.Text;
                        mercadoria.TG_Categoria = dd_Categoria.Text;
                        mercadoria.VL_ValorCompra = Convert.ToDouble(tb_ValorCompra.Text);
                        mercadoria.VL_ValorVenda = Convert.ToDouble(tb_ValorVenda.Text);
                        mercadoria.VL_Estoque = Convert.ToInt32(tb_Estoque.Text);
                        mercadoria.DT_Data = dataAgora.ToString("MM/dd/yyyy HH:mm:ss");
                        new Mercadoria().cadastraMercadoria(mercadoria);
                    }
                    carregarCategorias();
                    tabControl1.SelectedIndex = 0;
                    limparFormulario();
                    MessageBox.Show("Mercadoria cadastrada/alterada com sucesso", "Sucesso");
                }
                catch (FormatException E)
                {
                    // Perform some action here, and then throw a new exception.
                    MessageBox.Show("Ocorreu um erro no cadastro\nVerifique que:\n - Alguns campos aceitam apenas números\n\n Caso persistir o erro, contate o administrador", "Erro no cadastro");
                }
            }
            
        }


        private void tb_Referencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(tb_Referencia.Text != "")
                {
                    try
                    {
                        preencheFormulario(Convert.ToInt32(tb_Referencia.Text));
                    }
                    catch (FormatException E)
                    {
                        // Perform some action here, and then throw a new exception.
                        MessageBox.Show("Ocorreu um erro no campo digitado\nVerifique que:\n - O campo 'Referencia' deve estar preenchido\n - O campo deve possuir apenas números\n\n Caso persistir o erro, contate o administrador", "Erro de conversão");
                    }
                }
                
            }
        }

        public void preencheFormulario(int referencia)
        {
            var mercadoria = new Mercadoria().retornaMercadoria(referencia);
            if (mercadoria != null)
            {
                tb_Referencia.Text = ""+ mercadoria.CD_Referencia;
                tb_Nome.Text = mercadoria.NM_Nome;
                tb_ValorCompra.Text = "" + mercadoria.VL_ValorCompra;
                tb_ValorVenda.Text = "" + mercadoria.VL_ValorVenda;
                int indexador = new Mercadoria().retornaIDCategoria(mercadoria.TG_Categoria);
                dd_Categoria.SelectedIndex = indexador;
                tb_Estoque.Text = "" + mercadoria.VL_Estoque;
                tb_ValorVenda.Focus();
                tb_Referencia.Enabled = false;
                lb_01.Text = "Atualizar mercadoria";
            }
            else MessageBox.Show("Mercadoria não encontrada");
        }

        private void tb_Lucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tb_Lucro.Text != "")
                {
                    try
                    {
                        var ValorCompra = Convert.ToDouble(tb_ValorCompra.Text);
                        double NovoValor = (Convert.ToDouble(tb_Lucro.Text) / (double)100 * (double)ValorCompra + ValorCompra);
                        tb_ValorVenda.Text = "" + NovoValor;
                    }
                    catch (FormatException E)
                    {
                        // Perform some action here, and then throw a new exception.
                        MessageBox.Show("Ocorreu um erro no campo digitado\nVerifique que:\n - O campo 'Valor na Compra deve estar preenchido'\n - O campo deve possuir apenas números\n\n Caso persistir o erro, contate o administrador", "Erro de conversão");
                    }
                }
            }
        }

        private void tb_ValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tb_ValorVenda.Text != "")
                {
                    try
                    {
                        var ValorVenda = Convert.ToDouble(tb_ValorVenda.Text);
                        var ValorCompra = Convert.ToDouble(tb_ValorCompra.Text);
                        double NovoLucro = ((ValorVenda - (double)ValorCompra) / (double)ValorCompra * (double)100);
                        tb_Lucro.Text = "" + NovoLucro;
                    }
                    catch (FormatException E)
                    {
                        // Perform some action here, and then throw a new exception.
                        MessageBox.Show("Ocorreu um erro no campo digitado\nVerifique que:\n - O campo 'Valor na Compra' deve estar preenchido\n - O campo deve possuir apenas números\n\n Caso persistir o erro, contate o administrador","Erro de conversão");
                    }
                }
            }
        }


        private void tb_Estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tb_ValorVenda.Text != "")
                {
                    btn_Enviar_Click(sender, e);
                }
            }
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


        public void carregarCategorias()
        {
            dgv_Mercadorias.Rows.Clear();
            dd_Categoria.Items.Clear();
            var mercadoria = new Mercadoria().retornaTodaMercadoria();
            foreach (var m in mercadoria)
            {
                dgv_Mercadorias.Rows.Add(m.CD_Referencia, m.NM_Nome, m.TG_Categoria, m.VL_ValorVenda, m.VL_Estoque);

            }
            dd_Categoria.Items.Add("Selecione:");
            var categoria = new Mercadoria().retornaCategorias();
            foreach (var elemento in categoria)
            {
                dd_Categoria.Items.Add(elemento.CD_Nome);
            }



            dd_Categoria.SelectedIndex = 0;
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {
            cadCategoria cadCategoria = new cadCategoria();
            cadCategoria.ShowDialog();
            carregarCategorias();
        }

        private void dd_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ActiveControl = tb_ValorCompra;
            }
        }

        private void dd_Categoria_onItemSelected(object sender, EventArgs e)
        {

        }

        private void dd_Categoria_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }
        public void limparFormulario()
        {
            lb_01.Text = "Cadastrar mercadoria";
            tb_Referencia.Text = "";
            tb_Nome.Text = "";
            tb_ValorCompra.Text = "";
            tb_ValorVenda.Text = "";
            dd_Categoria.SelectedIndex = 0;
            tb_Estoque.Text = "";
            tb_Lucro.Text = "";
            tb_Referencia.Enabled = true;
            tb_Referencia.Focus();
        }
        private void dgv_Mercadorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgv_Mercadorias.CurrentRow.Index;
            int value = Convert.ToInt32((string)dgv_Mercadorias[0, i].Value.ToString());
            preencheFormulario(value);
            tabControl1.SelectedIndex = 1;
            tb_ValorVenda.Focus();

        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                int referencia = Convert.ToInt32(tb_Referencia.Text);
                new Mercadoria().RemoveMercadoria(referencia);
                carregarCategorias();
                tabControl1.SelectedIndex = 0;
                limparFormulario();
                MessageBox.Show("Mercadoria apagada com sucesso do sistema!", "Sucesso");
            }
            catch (FormatException)
            {
                // Perform some action here, and then throw a new exception.
                MessageBox.Show("Ocorreu um erro ao deletar a mercadoria\nVerifique que:\n - O campo 'Referencia' deve estar preenchido\n - O campo deve possuir apenas números\n\n Caso persistir o erro, contate o administrador", "Erro de conversão");
            }
        }

        
        private void tb_Filtro_TextChanged(object sender, EventArgs e)
        {
            carregaMercadoriaFiltro();
        }

        private void tb_Lucro_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
