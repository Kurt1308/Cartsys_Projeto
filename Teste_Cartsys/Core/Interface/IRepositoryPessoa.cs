using Core.Interface.Repository;
using Domain.Entity;
using Nest;

namespace Core.Interface
{
    public interface IRepositoryPessoa : IRepositoryBase<Pessoa>
    {
        string CadastrarPessoa(Pessoa pessoa);
        Pessoa PesquisarPessoa(string nomePessoa);
        Pessoa AlterarSituacaoPessoa(string nomePessoa);
        Pessoa EditarPessoa(string nomePessoaOld, string nomePessoaNew, string cargoPessoaNew);
        Pessoa DeletarPessoa(string nomePessoa);
        Pessoa DetalhesPessoa(int numeroRegistro);

    }
}
