using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Franthesk.Model;
namespace Franthesk.Controller
{
    public class Usuario
    {
        public USUARIO RetornarPorLoginESenha(string login, string senha)
        {
            using (var conexao = new frantheskEntities())
            {
               return conexao.USUARIO.AsNoTracking().FirstOrDefault(x => x.TG_Login == login && x.NR_Senha == senha);
            }
        }

        //public bool Administrador(string login, string senha)
        //{
        //    using (var conexao = new frantheskEntities())
        //    {
        //        return conexao.USUARIO.AsNoTracking().FirstOrDefault(x => x.TG_Login == login && x.NR_Senha == senha && x.CD_Admin == 1) != null;
        //    }
        //}

        public void cadastraUsuario(USUARIO usuario)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.USUARIO.Add(usuario);
                conexao.SaveChanges();
            }
        }
    }
}
