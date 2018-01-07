namespace WEB.Models
{
    public class Margen
    {
        public virtual int Id { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Margen SequencialMargem { get; set; }
        public virtual decimal ValorMargem { get; set; }
        public virtual int Situacao { get; set; }
    }
}
