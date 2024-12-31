using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interface;
using Core.Interface.Repository;
using Core.Service;
using Domain.Entity;
using Nest;

namespace Service
{
    public class ServicePessoa : ServiceBase<Pessoa>, IServicePessoa
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public ServicePessoa(IRepositoryPessoa repositoryPessoa) : base(repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        public string CadastrarPessoa(Pessoa pessoa)
        {
            string retorno;

            retorno = _repositoryPessoa.CadastrarPessoa(pessoa);

            return retorno;
        }

        public string PesquisarPessoa(string numRegistro)
        {
            string pessoa;

            pessoa = _repositoryPessoa.PesquisarPessoa(numRegistro);

            return pessoa;
        }
    }
}
