using FluentNHibernate.Mapping;
using WEB.Models;

namespace WEB.DAL.Mapeamento
{
    public class MargemMap : ClassMap<Margen>
    {
        public MargemMap()
        {
            Table("Margens");

            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.ValorMargem).Not.Nullable();
            Map(x => x.Situacao).Not.Nullable();

            HasOne(x => x.Funcionario).Cascade.All();
            HasOne(x => x.Produto).Cascade.All();
            HasOne(x => x.SequencialMargem).Cascade.All();
        }
    }
}