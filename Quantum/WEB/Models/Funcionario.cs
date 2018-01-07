namespace WEB.Models
{
    public class Funcionario
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string CPF { get; set; }
        public virtual string Matricula { get; set; }
        public virtual int Situacao { get; set; }
    }
}
