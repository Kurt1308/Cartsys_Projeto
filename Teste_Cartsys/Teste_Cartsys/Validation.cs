using System.Text.RegularExpressions;
using Domain.Entity;

namespace Teste_Cartsys
{
    public class Validation
    {
        private const string msgCampoNaoInformado = "CAMPO NÃO INFORMADO";
        private const string msgEstadoCivil = "Campo estado civil deve ser SOLTEIRO ou CASADO.";
        private const string msgValidaNumeroInteiro = "CAMPO DEVE CONTER APENAS NÚMEROS INTEIROS";
        private const string msgFormatoEmail = "EMAIL EM FORMATO NÃO ACEITO PELO SISTEMA.";
        
        
        /// <summary>
        /// Método principal de validação
        /// retorno mensagem de erro na validação
        /// </summary>
        /// <param name="objeto_input">string </param>
        /// <returns>bool</returns>
        public string ValidaDados(Pessoa pessoa)
        {
            string id = pessoa.Idade;
            int idade = (int)Convert.ToInt64(id);

            string cpf = pessoa.CPF;
            int CPF = (int)Convert.ToInt64(cpf);

            if (!ValidaUsuarioEmBranco(pessoa.Nome))
                return msgCampoNaoInformado + ": Preencher nome do usuário no cadastro.";

            if (!ValidaUsuarioEmBranco(pessoa.Cargo))
                return msgCampoNaoInformado + ": Preencher cargo do usuário no cadastro.";

            if (!ValidaUsuarioEmBranco(pessoa.Bairro))
                return msgCampoNaoInformado + ": Preencher Bairro do usuário no cadastro.";

            if (!ValidaEstadoCivil(pessoa.EstadoCivil))
                return msgEstadoCivil;

            if (!ValidaCampoNumerosInteiros(idade))
                return msgValidaNumeroInteiro + ": CAMPO IDADE. ";

            if (!ValidaCampoNumerosInteiros(CPF))
                return msgValidaNumeroInteiro + ": CAMPO CPF. ";

            if (!ValidaEmail(pessoa.Email))
                return msgFormatoEmail;

            return String.Empty;
        }
        /// <summary>
        /// Valida se campo de usuário esta preenchido ou maior que 50 caracteres 
        /// true = o campo usuário esta preenchido;
        /// false = o campo usuário esta em branco ou maior que 50 caracteres 
        /// </summary>
        /// <param name="usuario">string </param>
        /// <returns>bool</returns>
        protected bool ValidaUsuarioEmBranco(string campo)
        {
            if (campo.Equals(string.Empty) || campo.Equals(""))
                return false;
            return campo == "" ? false : campo.Length > 50 ? false : true;
        }
        /// <summary>
        /// Valida se campo email esta vazio ou maior que 50 caracteres 
        /// False = o campo não passou na validação
        /// True = o campo passou na validação
        /// </summary>
        /// <param name="email">string </param>
        /// <returns>bool</returns>
        protected bool ValidaEmail(string campo)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (!rg.IsMatch(campo))
                return false;

            return campo == "" ? false : campo.Length > 50 ? false : true;
        }
        /// <summary>
        /// Valida tipo_usuario = User ou Admin
        /// False = o campo não passou na validação
        /// True = o campo passou na validação
        /// </summary>
        /// <param name="tipo_usuario">string </param>
        /// <returns>bool</returns>
        public bool ValidaEstadoCivil(string campo)
        {
            if (campo.ToUpper() == "SOLTEIRO" || campo.ToUpper() == "CASADO")
                return true;
            return false;
        }
        /// <summary>
        /// Valida se campo informado é apenas numérico
        /// False = o campo não passou na validação
        /// True = o campo passou na validação
        /// </summary>
        /// <param name="numeroRegistro">string </param>
        /// <returns>bool</returns>
        public bool ValidaCampoNumerosInteiros(int campo)
        {
            // You can add validation rules based on your specific needs.
            if (campo >= 0)  // Example: Validate that it's a non-negative integer
            {
                return true;
            }
            return false;
        }

    }
}
