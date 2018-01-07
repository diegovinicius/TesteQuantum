using FluentNHibernate.Mapping;
using WEB.Models;

namespace WEB.DAL.Mapeamento
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Table("Produtos");

            Id(x => x.Codigo).GeneratedBy.Identity();

            Map(x => x.Nome);
            Map(x => x.Situacao);
        }
    }
}