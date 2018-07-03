using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesComplementoEndereco : AlterdataBase
    {
        private string identificador;
        private string codigoChamada;
        private string nomeCliente;
        private string telefone;
        private string fax;
        private string celular;
        private string email;
        private string pessoaContato;
        private string statusEnderecoPrincipal;
        private string statusEnderecoEntrega;
        private string statusEnderecoCobranca;
        private string statusEnderecoCorrespondencia;
        private string statusEnderecoComercial;
        private string statusEnderecoResidencial;
        private string observacao;
        private string sequencialEndereco;
        private string cnpjCpf;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamada
        {
            get { return codigoChamada; }
            set { codigoChamada = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = PreencherComEspacos(value, 50); }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = PreencherComEspacos(value, 50); }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = PreencherComEspacos(value, 50); }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = PreencherComEspacos(value, 50); }
        }

        public string Email
        {
            get { return email; }
            set { email = PreencherComEspacos(value, 50); }
        }

        public string PessoaContato
        {
            get { return pessoaContato; }
            set { pessoaContato = PreencherComEspacos(value, 50); }
        }

        public string StatusEnderecoPrincipal
        {
            get { return statusEnderecoPrincipal; }
            set { statusEnderecoPrincipal = PreencherComEspacos(value, 1); }
        }

        public string StatusEnderecoEntrega
        {
            get { return statusEnderecoEntrega; }
            set { statusEnderecoEntrega = PreencherComEspacos(value, 1); }
        }

        public string StatusEnderecoCobranca
        {
            get { return statusEnderecoCobranca; }
            set { statusEnderecoCobranca = PreencherComEspacos(value, 1); }
        }

        public string StatusEnderecoCorrespondencia
        {
            get { return statusEnderecoCorrespondencia; }
            set { statusEnderecoCorrespondencia = PreencherComEspacos(value, 1); }
        }

        public string StatusEnderecoComercial
        {
            get { return statusEnderecoComercial; }
            set { statusEnderecoComercial = PreencherComEspacos(value, 1); }
        }

        public string StatusEnderecoResidencial
        {
            get { return statusEnderecoResidencial; }
            set { statusEnderecoResidencial = PreencherComEspacos(value, 1); }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = PreencherComEspacos(value, 100); }
        }

        /// <summary>
        /// Está assossiado com o SequencialEndereco da classe ClientesEndereco
        /// </summary>
        public string SequencialEndereco
        {
            get { return sequencialEndereco; }
            set { sequencialEndereco = Convert.ToInt32(value).ToString("D2"); }
        }

        public string CnpjCpf
        {
            get { return cnpjCpf; }
            set { cnpjCpf = PreencherComEspacos(Regex.Replace(value ?? string.Empty, "[^0-9]", ""), 18); }
        }

        public ClientesComplementoEndereco()
        {
            Identificador = "001003";
            SequencialEndereco = "01";
        }
    }
}
