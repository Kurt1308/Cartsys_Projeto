using Core.Interface;
using Domain.Entity;
using Repositories;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Teste_Cartsys
{
    public partial class Form1 : Form
    {
        private readonly IRepositoryPessoa _repositoryPessoa;
        private readonly Validation _validation;

        public Form1()
        {
            InitializeComponent();

            // Obter o caminho base do arquivo de configuração
            var basePath = Directory.GetCurrentDirectory();

            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
                .Build();

            // Obter a string de conexão do banco de dados
            string connectionString = config.GetConnectionString("SQLConn");

            // Configuração do DbContextOptions com a string de conexão
            var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // Inicializa o SqlContext com as opções configuradas
            var sqlContext = new SqlContext(optionsBuilder.Options);

            // Inicialize o RepositoryPessoa com o SqlContext
            _repositoryPessoa = new RepositoryPessoa(sqlContext);

            //Inicialize a classe Validation
            _validation = new Validation();
        }

        // Método para cadastrar uma pessoa
        private void buttonEnviarCadastro_Click(object sender, EventArgs e)
        {
            string retorno;
            string mensagemValidacao;

            // Captura os dados dos campos de entrada
            string nome = this.textBoxNome.Text;
            string cpf = this.textBoxCPF.Text;
            string idade = this.textBoxIdade.Text;
            string email = this.textBoxEmail.Text;
            string estadoCivil = this.textBoxEstadoCivil.Text;
            string cargo = this.textBoxEstadoCivil.Text;
            bool situacao = true;
            string bairro = this.textBoxBairro.Text;

            // Cria uma instância da classe Pessoa com os dados capturados
            Pessoa pessoa = new Pessoa(nome, cpf, idade, email, estadoCivil, cargo, situacao, bairro);

            //Processo que valida input
            mensagemValidacao = _validation.ValidaDados(pessoa);

            if(mensagemValidacao.Equals(string.Empty) || mensagemValidacao.Equals("") || String.IsNullOrEmpty(mensagemValidacao))
            {
                // Cadastrar a pessoa usando o repositório
                retorno = _repositoryPessoa.CadastrarPessoa(pessoa);
                MessageBox.Show(retorno, "Cadastro");
            } else
            {
                MessageBox.Show(mensagemValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpar os campos de cadastro
            this.limparDadosCadastro();
        }

        // Limpar os campos após cadastro
        private void limparDadosCadastro()
        {
            this.textBoxNome.Text = null;
            this.textBoxCPF.Text = null;
            this.textBoxIdade.Text = null;
            this.textBoxEmail.Text = null;
            this.textBoxEstadoCivil.Text = null;
            this.textBoxBairro.Text = null;
            this.textBoxCargo.Text = null;
        }

        private void limparDadosDetalhes()
        {
            this.textBoxNumRegistroDetalhes.Text = null;
        }

        private void limparDadosRegistro()
        {
            this.textBoxPesquisarNomeRegistro.Text = null;
        }

        // Método para pesquisar pessoa pelo número de registro
        private void buttonPesquisarNumRegistro_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            string nomePessoa = this.textBoxPesquisarNomeRegistro.Text;
            pessoa = _repositoryPessoa.PesquisarPessoa(nomePessoa);

            if(pessoa == null)
            {
            MessageBox.Show("Pessoa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
            // Exibir o nome da pessoa encontrada ou uma mensagem de erro
            this.labelCargoPessoaRet.Text = pessoa.Cargo;
            this.labelSituacaoPessoaRet.Text = true ? "Ativo" : "Inativo";

                limparDadosRegistro();
            }

        }

        // Método para pesquisar e exibir os detalhes de uma pessoa
        private void buttonPesquisarDetalhesPessoa_Click(object sender, EventArgs e)
        {
            string num = this.textBoxNumRegistroDetalhes.Text;
            int numeroRegistro = (int)Convert.ToInt64(num);

            bool validacao;
            validacao = _validation.ValidaCampoNumerosInteiros(numeroRegistro);

            if (validacao) { 
                // Obter detalhes da pessoa usando o repositório
                Pessoa pessoa = _repositoryPessoa.DetalhesPessoa(numeroRegistro);

                // Exibir os detalhes na interface
                if (pessoa != null)
                {
                    this.labelNomeRetDetalhes.Text = pessoa.Nome;
                    this.labelIdadeRetDetalhes.Text = pessoa.Idade;
                    this.labelEmailRetDetalhes.Text = pessoa.Email;
                    this.labelEstadoCivilRetDetalhes.Text = pessoa.EstadoCivil;

                    limparDadosDetalhes();
                }
                else
                {
                    MessageBox.Show("Pessoa não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo informado deve conter apenas números inteiros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para exibir o painel de cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            this.panelDetalhes.Visible = false;
            this.panelRegistro.Visible = false;
            this.panelCadastro.Visible = true;
        }

        // Método para exibir o painel de registro
        private void button2_Click(object sender, EventArgs e)
        {
            this.panelCadastro.Visible = false;
            this.panelDetalhes.Visible = false;
            this.panelRegistro.Visible = true;
        }

        // Método para exibir o painel de detalhes
        private void button3_Click(object sender, EventArgs e)
        {
            this.panelRegistro.Visible = false;
            this.panelCadastro.Visible = false;
            this.panelDetalhes.Visible = true;
        }

        // Método de clique no Label (exemplo sem ação definida)
        private void label1_Click(object sender, EventArgs e) { }

        // Método de clique no Label (exemplo sem ação definida)
        private void label2_Click(object sender, EventArgs e) { }
    }
}
