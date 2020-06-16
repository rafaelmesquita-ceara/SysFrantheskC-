using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Franthesk.Model;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Franthesk.Controller
{
    class Venda
    {
        public int idUltimaVenda()
        {
            using (var conexao = new frantheskEntities())
            {
                var venda = conexao.VENDA.OrderByDescending(x => x.CD_ID).FirstOrDefault();
                if (venda != null) return venda.CD_ID+1;
                else return 1;

            }

        }

        public void cadastraVenda(VENDA venda)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.VENDA.Add(venda);
                conexao.SaveChanges();
            }
        }
        public void cadastraMercadoriaVendida(MERCADORIA_VENDA mercadoria)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.MERCADORIA_VENDA.Add(mercadoria);
                conexao.SaveChanges();
            }
        }

        public List<VENDA> retornaTodaVenda()
        {
            using (var conexao = new frantheskEntities())
            {
                var listaVendas = conexao.VENDA.ToList();

                return listaVendas;

            }
        }

        public List<MERCADORIA_VENDA> retornaMercadoriaVendida(int idVenda)
        {
            using (var conexao = new frantheskEntities())
            {
                var listaMercadoriaVendida = conexao.MERCADORIA_VENDA.Where(x => x.CD_Venda == idVenda).ToList();

                return listaMercadoriaVendida;

            }
        }
    }
}
