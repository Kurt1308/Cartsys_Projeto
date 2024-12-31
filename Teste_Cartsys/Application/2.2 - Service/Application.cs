using Application;
using Application.Response;
using Core.Service;
using Domain.Entity;

namespace Application._2._2___Service
{
    public class Application : IApplication
    {
        private readonly IServicePessoa _servicePessoa;

        public Application(IServicePessoa servicePessoa)
        {
            _servicePessoa = servicePessoa;
        }

        public string CadastrarUsuario(Pessoa pessoa)
        {
            string retorno;
            retorno = _servicePessoa.CadastrarPessoa(pessoa);
            return retorno;
        }

        public Pessoa DetalhesPessoa(string numeroRegistro)
        {
            Pessoa pessoa = new Pessoa();

            pessoa = _servicePessoa.DetalhesPessoa(numeroRegistro);

            return pessoa;
        }

        public string PesquisarPessoa(string numRegistro)
        {
            string pessoa;

            pessoa = _servicePessoa.PesquisarPessoa(numRegistro);

            return pessoa;
        }
    }
}
