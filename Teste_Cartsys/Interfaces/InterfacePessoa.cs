using Dominios;

namespace Interfaces
{
    public interface InterfacePessoa
    {
        void RegistrarPessoa(Pessoa pessoa);
        String PesquisarPessoa(String numeroRegistro);
    }
}
