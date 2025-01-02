using Core.Interface;
using Domain.Entity;
using Elasticsearch.Net;
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
            // Create a new Pessoa instance and set its Nome property
            Pessoa pessoaPesquisada = new Pessoa();
            pessoaPesquisada.Nome = pessoa.Nome;  // Assuming pessoa is already defined and has the Nome value

            // Query the Pessoa DbSet to find the first matching record based on the Nome
            pessoaPesquisada = _sqlContext.pessoa
                .Where(x => x.Nome == pessoaPesquisada.Nome)
                .FirstOrDefault();  // Get the first matching record or null if no match is found

            if (pessoaPesquisada == null)
            {
                string retorno = "Ok, Pessoa cadastrada com sucesso!";
                var data = DateTime.UtcNow;
                // Ensure CPF is long enough (it should be 14 characters including the dots and hyphen)
                string maskedCPF = pessoa.CPF;

                if (maskedCPF.Length == 14)  // Ensure the CPF follows the format 111.333.444-00
                {
                    // Mask the characters between index 5 and 11 (the second part of the CPF)
                    maskedCPF = maskedCPF.Substring(0, 4) + "xxxxx" + maskedCPF.Substring(11);
                }

                Pessoa insert = new Pessoa()
                {
                    Nome = pessoa.Nome,
                    CPF = maskedCPF, // Save the masked CPF
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
            return $"Pessoa já cadastrada no sistema.";
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
            // Remove spaces and convert to lowercase for case-insensitive comparison
            string nomePessoaNormalized = nomePessoa.Replace(" ", "").ToLower();

            // Query the database and perform the comparison with normalized data
            Pessoa pessoa = _sqlContext.pessoa
                .Where(x => x.Nome.Replace(" ", "").ToLower() == nomePessoaNormalized)
                .FirstOrDefault();

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

        public Pessoa DeletarPessoa(string nomePessoa)
        {
            // Retrieve the Pessoa entity based on the Nome
            Pessoa pessoa = _sqlContext.pessoa
                .Where(x => x.Nome == nomePessoa)
                .FirstOrDefault();

            if (pessoa != null)
            {
                try
                {
                    // Mark the entity for deletion
                    _sqlContext.pessoa.Remove(pessoa);

                    // Save the changes to the database, which will delete the record
                    _sqlContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Handle the exception, log it, or return a custom error message
                    Console.WriteLine($"Error ao deletar Pessoa: {ex.Message}");
                    // Optionally, log the exception using a logger or throw the exception
                    throw;  // Optionally, rethrow the exception if you want it to propagate
                }
            }

            // Return the deleted pessoa or null if not found
            return pessoa;
        }

        public Pessoa EditarPessoa(string nomePessoaOld, string nomePessoaNew, string cargoPessoaNew)
        {
            // Retrieve the Pessoa entity based on the Nome
            Pessoa pessoa = _sqlContext.pessoa
                .Where(x => x.Nome == nomePessoaOld)
                .FirstOrDefault();

            if (pessoa != null)
            {
                // Toggle the value of the Situacao field
                pessoa.Nome = nomePessoaNew; // Toggle Situacao
                pessoa.Cargo = cargoPessoaNew; // Toggle Situacao

                // Save the changes back to the database
                _sqlContext.SaveChanges();
            }
                Pessoa pessoaUpdate = _sqlContext.pessoa
                .Where(x => x.Nome == nomePessoaNew)
                .FirstOrDefault();

            return pessoaUpdate;  // Return the updated Pessoa object
        }
    }
}
