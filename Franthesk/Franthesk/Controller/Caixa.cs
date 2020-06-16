using Franthesk.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franthesk.Controller
{
    class Caixa
    {
        public CAIXA caixaAberto()
        {
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            using (var conexao = new frantheskEntities())
            {
                var caixa = conexao.CAIXA.Where(x => x.NM_Status == "aberto" && x.DT_Data == data).FirstOrDefault();
                return caixa;
            }

        }
        public void abreCaixa(CAIXA caixa)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.CAIXA.Add(caixa);
                conexao.SaveChanges();
            }
        }

        public void AlteraCaixa(CAIXA caixa)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.Entry(caixa).State = EntityState.Modified;
                conexao.SaveChanges();
            }
        }
    }
}
