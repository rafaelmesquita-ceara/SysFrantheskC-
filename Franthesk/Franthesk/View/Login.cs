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

namespace Franthesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }



        private void btn_Acesso_Click_1(object sender, EventArgs e)
        {
            var usuario = new Usuario().RetornarPorLoginESenha(tb_Login.Text, tb_Senha.Text);
            if (usuario != null)
            {
                if(usuario.CD_Admin == 1)
                {
                    MessageBox.Show("ADMINISTRADOR AUTENTICADO");
                }
                else MessageBox.Show("FUNCIONARIO AUTENTICADO");
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
                MessageBox.Show("USUARIO NÃO ENCONTRADO");
        }
    }
}
