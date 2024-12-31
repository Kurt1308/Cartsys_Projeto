using Application.Response;
using Domain.Entity;

namespace Application
{
    public interface IApplication
    {
        string CadastrarUsuario(Pessoa pessoa);
        string PesquisarPessoa(string numRegistro);
        Pessoa DetalhesPessoa(string numeroRegistro);
    }
}
