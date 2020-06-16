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
    class Mercadoria
    {
        public void cadastraMercadoria(MERCADORIA mercadoria)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.MERCADORIA.Add(mercadoria);
                conexao.SaveChanges();
            }
        }
        public void alteraMercadoria(MERCADORIA mercadoriaNovo)
        {
            using (var conexao = new frantheskEntities())
            {
                //var mercadoria = conexao.MERCADORIA.FirstOrDefault(x => x.CD_Referencia == referencia);
                conexao.Entry(mercadoriaNovo).State = EntityState.Modified;

                //conexao.MERCADORIA.AddOrUpdate(mercadoriaNovo);
                //mercadoria = mercadoriaNovo;
                conexao.SaveChanges();
            }
        }
        public void cadastraCategoria(CATEGORIAS categoria)
        {
            using (var conexao = new frantheskEntities())
            {
                conexao.CATEGORIAS.Add(categoria);
                conexao.SaveChanges();
            }
        }
        public MERCADORIA retornaMercadoria(int referencia)
        {
            using (var conexao = new frantheskEntities())
            {
                return conexao.MERCADORIA.AsNoTracking().FirstOrDefault(x => x.CD_Referencia == referencia);
            }
        } 
        public List<MERCADORIA> retornaTodaMercadoria()
        {
            using (var conexao = new frantheskEntities())
            {
                var listaMercadorias = conexao.MERCADORIA.ToList();
                
                return listaMercadorias;

            }
        }
        public List<MERCADORIA> retornaMercadoriaPorNome(String nome)
        {
            using (var conexao = new frantheskEntities())
            {
                var listaMercadorias = conexao.MERCADORIA.Where(x => x.NM_Nome.Contains(nome)).ToList();
                return listaMercadorias;

            }
        }
        public void RemoveMercadoria(int referencia)
        {
            using (var conexao = new frantheskEntities())
            {
                var mercadoria = conexao.MERCADORIA.Where(x => x.CD_Referencia == referencia);
                conexao.MERCADORIA.RemoveRange(mercadoria);
                conexao.SaveChanges();
            }
        }

        public List<CATEGORIAS> retornaCategorias()
        {
            using (var conexao = new frantheskEntities())
            {
                var listaCategorias = conexao.CATEGORIAS.ToList();
                return listaCategorias;
            }
        }
        public int retornaIDCategoria(String categoria)
        {
            using (var conexao = new frantheskEntities())
            {
                var id = conexao.CATEGORIAS.AsNoTracking().FirstOrDefault(x => x.CD_Nome == categoria);
                return id.CD_ID;
            }
        }
        public bool mercadoriaExistente(int referencia)
        {
            using (var conexao = new frantheskEntities())
            {
                return conexao.MERCADORIA.AsNoTracking().FirstOrDefault(x => x.CD_Referencia == referencia) != null;
            }
        }
    }
}
