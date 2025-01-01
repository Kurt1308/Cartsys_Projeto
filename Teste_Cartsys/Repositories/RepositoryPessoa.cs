using Core.Interface;
using Domain.Entity;
using Microsoft.SqlServer.Management.Smo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        private readonly Data.SqlContext _sqlContext;

        public RepositoryPessoa(Data.SqlContext context) : base(context)
        {
            _sqlContext = context;
        }

        public string CadastrarPessoa(Pessoa pessoa)
        {
            string retorno = "Ok, Pessoa cadastrada com sucesso!";
            var data = DateTime.UtcNow;
            Pessoa insert = new Pessoa()
            {
                Nome = pessoa.Nome,
                CPF = pessoa.CPF,
                Idade = pessoa.Idade,
                Email = pessoa.Email,
                EstadoCivil = pessoa.EstadoCivil,
                Bairro = pessoa.Bairro,
                Cargo = pessoa.Cargo,
                Situacao = true,
                DataCriacao = data
            };

            try
            {
                // Add the new person to the context and save changes
                _sqlContext.pessoa.Add(insert);
                _sqlContext.SaveChanges();

                return retorno;
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging purposes
                Console.WriteLine(ex.Message);  // You can log this to a file or logger

                return $"Erro ao cadastrar pessoa: {ex.Message}";
            }
        }

        public Pessoa DetalhesPessoa(int numeroRegistro)
        {
            Pessoa pessoa = new Pessoa();

            pessoa = pessoa = _sqlContext.pessoa
                .Where(x => x.NumeroRegistro == numeroRegistro).FirstOrDefault();

            return pessoa;
        }

        public Pessoa PesquisarPessoa(string nomePessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa = _sqlContext.pessoa
                .Where(x => x.Nome == nomePessoa).FirstOrDefault();

            return pessoa;
        }

        public Pessoa AlterarSituacaoPessoa(string nomePessoa)
        {
            // Retrieve the Pessoa entity based on the Nome
            Pessoa pessoa = _sqlContext.pessoa
                .Where(x => x.Nome == nomePessoa)
                .FirstOrDefault();

            if (pessoa != null)
            {
                // Toggle the value of the Situacao field
                pessoa.Situacao = !pessoa.Situacao; // Toggle Situacao

                // Save the changes back to the database
                _sqlContext.SaveChanges();
            }

            return pessoa;  // Return the updated Pessoa object
        }

        //public Pessoa AlterarSituacaoPessoa(string nomePessoa)
        //{
        //    // Retrieve the Pessoa entity based on the Nome
        //    Pessoa pessoa = _sqlContext.pessoa
        //        .Where(x => x.Nome == nomePessoa)
        //        .FirstOrDefault();

        //    if (pessoa != null)
        //    {
        //        // Toggle the value of the Situacao field
        //        Pessoa insert = new Pessoa()
        //        {
        //            Nome = pessoa.Nome,
        //            CPF = pessoa.CPF,
        //            Idade = pessoa.Idade,
        //            Email = pessoa.Email,
        //            EstadoCivil = pessoa.EstadoCivil,
        //            Bairro = pessoa.Bairro,
        //            Cargo = pessoa.Cargo,
        //            Situacao = pessoa.Situacao = true ? false : true,
        //            DataCriacao = pessoa.DataCriacao
        //        };

        //        // Save the changes back to the database
        //        _sqlContext.pessoa.Update(insert);
        //        _sqlContext.SaveChanges();
        //    }

        //    return pessoa;  // Return the updated Pessoa object

        //}
    }
}
