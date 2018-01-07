using FluentNHibernate.Mapping;
using WEB.Models;

namespace WEB.DAL.Mapeamento
{
    public class FuncionarioMap : ClassMap<Funcionario>
    {
        public FuncionarioMap()
        {
            Table("Funcionarios");

            Id(x => x.Codigo).GeneratedBy.Identity();
            Map(x => x.CPF).Not.Nullable();
            Map(x => x.Matricula).Not.Nullable();
            Map(x => x.Nome).Not.Nullable();
            Map(x => x.Situacao).Not.Nullable();
        }
    }
}