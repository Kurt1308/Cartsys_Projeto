using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Pessoa
    {
        [Key]
        public int NumeroRegistro { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
        public string Cargo { get; set; }
        public bool Situacao { get; set; }
        public string Bairro { get; set; }
        public DateTime DataCriacao { get; set; }

        public Pessoa()
        {
        }
        // Construtor para inicializar a entidade com os dados
        public Pessoa(string nome, string cpf, string idade, string email, string estadoCivil, string cargo, bool situacao, string bairro)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Email = email;
            EstadoCivil = estadoCivil;
            Cargo = cargo;
            Situacao = situacao;
            Bairro = bairro;
        }
    }
}
