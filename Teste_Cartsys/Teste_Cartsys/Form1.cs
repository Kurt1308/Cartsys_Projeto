using Core.Interface;
using Domain.Entity;
using Repositories;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Nest;

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
            string cargo = this.textBoxCargo.Text;
            bool situacao = true;
            string bairro = this.textBoxBairro.Text;

            // Cria uma instância da classe Pessoa com os dados capturados
            Pessoa pessoa = new Pessoa(nome, cpf, idade, email, estadoCivil, cargo, situacao, bairro);

            //Processo que valida input
            mensagemValidacao = _validation.ValidaDados(pessoa);

            if (mensagemValidacao.Equals(string.Empty) || mensagemValidacao.Equals("") || String.IsNullOrEmpty(mensagemValidacao))
            {
                // Cadastrar a pessoa usando o repositório
                retorno = _repositoryPessoa.CadastrarPessoa(pessoa);
                MessageBox.Show(retorno, "Cadastro");
            }
            else
            {
                MessageBox.Show(mensagemValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpar os campos de cadastro
            this.limparDadosCadastro();
        }

        // Método para pesquisar pessoa pelo número de registro
        private void buttonPesquisarNumRegistro_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            string nomePessoa = this.textBoxPesquisarNomeRegistro.Text;
            pessoa = _repositoryPessoa.PesquisarPessoa(nomePessoa);

            if (pessoa == null)
            {
                MessageBox.Show("Pessoa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Exibir o nome da pessoa encontrada ou uma mensagem de erro
                this.labelCargoPessoaRet.Text = pessoa.Cargo;

                if (pessoa.Situacao)
                {
                    this.labelSituacaoPessoaRet.Text = "Ativo";
                    this.buttonAlterarSituacao.Text = "Desativar";
                    this.buttonAlterarSituacao.Visible = true;
                    this.buttonDeletarPessoa.Visible = true;
                    this.buttonEditarPessoa.Visible = true;
                } else if(!pessoa.Situacao)
                {
                    this.labelSituacaoPessoaRet.Text = "Inativo";
                    this.buttonAlterarSituacao.Text = "Ativar";
                    this.buttonAlterarSituacao.Visible = true;
                    this.buttonDeletarPessoa.Visible = true;
                    this.buttonEditarPessoa.Visible = true;
                } else
                {
                    this.buttonAlterarSituacao.Text = "";
                    this.buttonAlterarSituacao.Visible = false;
                    this.buttonDeletarPessoa.Visible = false;
                    this.buttonEditarPessoa.Visible = false;
                }
                this.labelNomePessoaPesquisaRetorno.Text = pessoa.Nome;
            }

        }

        // Método para pesquisar e exibir os detalhes de uma pessoa
        private void buttonPesquisarDetalhesPessoa_Click(object sender, EventArgs e)
        {
            string num = this.textBoxNumRegistroDetalhes.Text;
            int numeroRegistro = (int)Convert.ToInt64(num);

            bool validacao;
            validacao = _validation.ValidaCampoNumerosInteiros(num);

            if (validacao)
            {
                // Obter detalhes da pessoa usando o repositório
                Pessoa pessoa = _repositoryPessoa.DetalhesPessoa(numeroRegistro);

                // Exibir os detalhes na interface
                if (pessoa != null)
                {
                    this.labelNomeRetDetalhes.Text = pessoa.Nome;
                    this.labelIdadeRetDetalhes.Text = pessoa.Idade;
                    this.labelEmailRetDetalhes.Text = pessoa.Email;
                    this.labelEstadoCivilRetDetalhes.Text = pessoa.EstadoCivil;
                    this.labelCPFDetalhesRet.Text = pessoa.CPF;
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

        private void buttonDeletarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            string nomePessoa = this.labelNomePessoaPesquisaRetorno.Text;
            pessoa = _repositoryPessoa.DeletarPessoa(nomePessoa);

            if (pessoa != null)
            {
                // Exibir o nome da pessoa encontrada ou uma mensagem de erro
                this.labelCargoPessoaRet.Text = "";
                this.labelNomePessoaPesquisaRetorno.Text = "";
                this.labelSituacaoPessoaRet.Text = "";
                this.buttonDeletarPessoa.Visible = false;
                this.buttonAlterarSituacao.Visible = false;
                this.buttonEditarPessoa.Visible = false;

                MessageBox.Show("Nº Registro deletado: " + pessoa.NumeroRegistro + Environment.NewLine + " Nome: " + pessoa.Nome, "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Erro ao deletar pessoa pesquisada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAlterarSituacao_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            string nomePessoa = this.labelNomePessoaPesquisaRetorno.Text;
            pessoa = _repositoryPessoa.AlterarSituacaoPessoa(nomePessoa);

            if (nomePessoa.IsNullOrEmpty())
            {
                MessageBox.Show("Nenhuma pessoa pesquisada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Exibir o nome da pessoa encontrada ou uma mensagem de erro
                this.labelCargoPessoaRet.Text = pessoa.Cargo;
                this.labelNomePessoaPesquisaRetorno.Text = pessoa.Nome;
                // Now, update the label text based on the Situacao value
                if (pessoa.Situacao == true)
                {
                    this.labelSituacaoPessoaRet.Text = "Ativo";  // Set label text to "Ativo" if Situacao is true
                }
                else
                {
                    this.labelSituacaoPessoaRet.Text = "Inativo"; // Set label text to "Inativo" if Situacao is false
                }

                if (this.labelSituacaoPessoaRet.Text == "Ativo")
                {
                    this.buttonAlterarSituacao.Text = "Desativar";
                    this.buttonAlterarSituacao.Visible = true;
                    this.buttonDeletarPessoa.Visible = true;
                    this.buttonEditarPessoa.Visible = true;
                }
                else if (this.labelSituacaoPessoaRet.Text == "Inativo")
                {
                    this.buttonAlterarSituacao.Text = "Ativar";
                    this.buttonDeletarPessoa.Visible = true;
                    this.buttonAlterarSituacao.Visible = true;
                    this.buttonEditarPessoa.Visible = true;
                }
                else
                {
                    this.buttonDeletarPessoa.Visible = false;
                    this.buttonAlterarSituacao.Visible = false;
                    this.buttonEditarPessoa.Visible = false;
                }
            }
        }

        private void buttonEditarPessoa_Click(object sender, EventArgs e)
        {
            if (this.textBoxEditCargoPessoa.Visible == false)
            {
                //Atualiza text button
                this.buttonEditarPessoa.Text = "Salvar";
                this.textBoxEditCargoPessoa.Visible = true;
                this.labelCargoPessoaRet.Visible = false;
                this.textBoxEditCargoPessoa.Text = this.labelCargoPessoaRet.Text;
                this.textBoxEditNomePessoa.Visible = true;
                this.labelNomePessoaPesquisaRetorno.Visible = false;
                this.textBoxEditNomePessoa.Text = this.labelNomePessoaPesquisaRetorno.Text;

            }
            else
            {
                Pessoa pessoa = new Pessoa();
                pessoa = _repositoryPessoa.EditarPessoa(this.labelNomePessoaPesquisaRetorno.Text, this.textBoxEditNomePessoa.Text, this.textBoxEditCargoPessoa.Text);

                //Atualiza text button
                this.buttonEditarPessoa.Text = "Editar";
                this.labelCargoPessoaRet.Text = pessoa.Cargo;
                this.textBoxEditCargoPessoa.Visible = false;
                this.labelCargoPessoaRet.Visible = true;
                this.textBoxEditNomePessoa.Visible = false;
                this.labelNomePessoaPesquisaRetorno.Visible = true;
                this.labelNomePessoaPesquisaRetorno.Text = pessoa.Nome;
            }
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
        // Limpar os campos após receber dados do painel detalhes
        private void limparDadosDetalhes()
        {
            this.textBoxNumRegistroDetalhes.Text = null;
            this.labelNomeRetDetalhes.Text = null;
            this.labelIdadeRetDetalhes.Text = null;
            this.labelEstadoCivilRetDetalhes.Text = null;
            this.labelEmailRetDetalhes.Text = null;
            this.labelCPFDetalhesRet.Text = null;
        }
        // Limpar os campos após receber dados do painel Pesquisar por Registro
        private void limparDadosRegistro()
        {
            this.textBoxPesquisarNomeRegistro.Text = null;
            this.labelCargoPessoaRet.Text = null;
            this.labelSituacaoPessoaRet.Text = null;
            this.labelNomePessoaPesquisaRetorno.Text = null;
        }

        // Método para exibir o painel de cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            this.panelDetalhes.Visible = false;
            this.limparDadosDetalhes();
            this.panelRegistro.Visible = false;
            this.limparDadosRegistro();
            this.panelCadastro.Visible = true;
        }

        // Método para exibir o painel de registro
        private void button2_Click(object sender, EventArgs e)
        {
            this.panelCadastro.Visible = false;
            this.limparDadosCadastro();
            this.panelDetalhes.Visible = false;
            this.limparDadosDetalhes();
            this.panelRegistro.Visible = true;
        }

        // Método para exibir o painel de detalhes
        private void button3_Click(object sender, EventArgs e)
        {
            this.panelRegistro.Visible = false;
            this.limparDadosRegistro();
            this.panelCadastro.Visible = false;
            this.limparDadosCadastro();
            this.panelDetalhes.Visible = true;
        }
        
        private void panelDetalhes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }
        // Método de clique no Label (exemplo sem ação definida)
        private void label1_Click(object sender, EventArgs e) { }

        // Método de clique no Label (exemplo sem ação definida)
        private void label2_Click(object sender, EventArgs e) { }
    }
}
