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
    public partial class cadCategoria : Form
    {
        public cadCategoria()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            CATEGORIAS categoria = new CATEGORIAS();
            categoria.CD_Nome = tb_Nome.Text;
            new Mercadoria().cadastraCategoria(categoria);
            this.Close();
        }
    }
}
