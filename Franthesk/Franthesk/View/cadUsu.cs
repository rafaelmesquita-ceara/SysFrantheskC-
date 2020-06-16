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
    public partial class cadUsu : Form
    {
        public cadUsu()
        {
            InitializeComponent();
        }


        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            USUARIO usuario = new USUARIO();
            usuario.NM_Nome = tb_Nome.Text;
            usuario.NR_Tel = tb_Tel.Text;
            usuario.TX_ENDE = tb_End.Text;
            usuario.TG_Login = tb_Login.Text;
            usuario.NR_Senha = tb_Senha.Text;
            usuario.CD_Admin = cb_Admin.Checked ? 1 : 0;
            new Usuario().cadastraUsuario(usuario);
            MessageBox.Show("Usuário cadastrado");
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Nome.Text = "";
            tb_Tel.Text = "";
            tb_End.Text = "";
            tb_Login.Text = "";
            tb_Senha.Text = "";
            cb_Admin.Checked = false;
        }
    }
}
