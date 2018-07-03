using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.ContasReceber
{
    public sealed class ContasReceberDadosPrincipais : AlterdataBase
    {
        private string identificador;
        private string codigoChamadaEmpresa;
        private string codigoChamadaPessoas;
        private string numeroTitulo;
        private string nomeTitulo;
        private string dataEmissao;
        private string dataVencimento;
        private string dataDisponivel;
        private string valorTitulo;
        private string codigoChamadaNaturezaLancamento;
        private string codigoChamadaFormaPagamento;
        private string codigoFebrabanBanco;
        private string codigoChamadaAgenciaBanco;
        private string codigoChamadaContaBancaria;
        private string numeroTituloBanco;
        private string codigoChamadaTipoCobranca;
        private string dataBaixaTitulo;
        private string valorBaixaTitulo;
        private string tipoBaixa;
        private string observacoes;
        private string identificadorTitulo;
        private string numeroAgenciaBancaria;
        private string numeroContaBancaria;
        private string categoriaPessoaTitulo;
        private string tipoPessoa;
        private string cnpjCpfPessoa;
        private string codigoChamadaSitAdministrativa;
        private string dataExclusaoTitulo;
        private string numeroDocumentoBaixaTitulo;
        private string codigoChamadaCentroCusto;
        private string statusCancelamentoBaixa;
        private string numeroItensTitulo;
        private string numeroCheque;
        private string statusIdentificadorTituloUnico;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEmpresa
        {
            get { return codigoChamadaEmpresa; }
            set { codigoChamadaEmpresa = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaPessoas
        {
            get { return codigoChamadaPessoas; }
            set { codigoChamadaPessoas = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NumeroTitulo
        {
            get { return numeroTitulo; }
            set { numeroTitulo = PreencherComEspacos(value, 20); }
        }

        public string NomeTitulo
        {
            get { return nomeTitulo; }
            set { nomeTitulo = PreencherComEspacos(value, 50); }
        }

        public string DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = PreencherComEspacos(value, 8); }
        }

        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = PreencherComEspacos(value, 8); }
        }

        public string DataDisponivel
        {
            get { return dataDisponivel; }
            set { dataDisponivel = PreencherComEspacos(value, 8); }
        }

        public string ValorTitulo
        {
            get { return valorTitulo; }
            set { valorTitulo = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamento
        {
            get { return codigoChamadaNaturezaLancamento; }
            set { codigoChamadaNaturezaLancamento = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaFormaPagamento
        {
            get { return codigoChamadaFormaPagamento; }
            set { codigoChamadaFormaPagamento = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoFebrabanBanco
        {
            get { return codigoFebrabanBanco; }
            set { codigoFebrabanBanco = Convert.ToInt32(value).ToString("D3"); }
        }

        public string CodigoChamadaAgenciaBanco
        {
            get { return codigoChamadaAgenciaBanco; }
            set { codigoChamadaAgenciaBanco = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaContaBancaria
        {
            get { return codigoChamadaContaBancaria; }
            set { codigoChamadaContaBancaria = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NumeroTituloBanco
        {
            get { return numeroTituloBanco; }
            set { numeroTituloBanco = PreencherComEspacos(value, 50); }
        }

        public string CodigoChamadaTipoCobranca
        {
            get { return codigoChamadaTipoCobranca; }
            set { codigoChamadaTipoCobranca = Convert.ToInt32(value).ToString("D6"); }
        }

        public string DataBaixaTitulo
        {
            get { return dataBaixaTitulo; }
            set { dataBaixaTitulo = PreencherComEspacos(value, 8); }
        }

        public string ValorBaixaTitulo
        {
            get { return valorBaixaTitulo; }
            set { valorBaixaTitulo = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string TipoBaixa
        {
            get { return tipoBaixa; }
            set { tipoBaixa = PreencherComEspacos(value, 1); }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = PreencherComEspacos(value, 200); }
        }

        public string IdentificadorTitulo
        {
            get { return identificadorTitulo; }
            set { identificadorTitulo = PreencherComEspacos(value, 10); }
        }

        public string NumeroAgenciaBancaria
        {
            get { return numeroAgenciaBancaria; }
            set { numeroAgenciaBancaria = PreencherComEspacos(value, 10); }
        }

        public string NumeroContaBancaria
        {
            get { return numeroContaBancaria; }
            set { numeroContaBancaria = PreencherComEspacos(value, 20); }
        }

        public string CategoriaPessoaTitulo
        {
            get { return categoriaPessoaTitulo; }
            set { categoriaPessoaTitulo = PreencherComEspacos(value, 1); }
        }

        public string TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = PreencherComEspacos(value, 1); }
        }

        public string CnpjCpfPessoa
        {
            get { return cnpjCpfPessoa; }
            set { cnpjCpfPessoa = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 18); }
        }

        public string CodigoChamadaSitAdministrativa
        {
            get { return codigoChamadaSitAdministrativa; }
            set { codigoChamadaSitAdministrativa = Convert.ToInt32(value).ToString("D6"); }
        }

        public string DataExclusaoTitulo
        {
            get { return dataExclusaoTitulo; }
            set { dataExclusaoTitulo = PreencherComEspacos(value, 8); }
        }

        public string NumeroDocumentoBaixaTitulo
        {
            get { return numeroDocumentoBaixaTitulo; }
            set { numeroDocumentoBaixaTitulo = PreencherComEspacos(value, 50); }
        }

        public string CodigoChamadaCentroCusto
        {
            get { return codigoChamadaCentroCusto; }
            set { codigoChamadaCentroCusto = Convert.ToInt32(value).ToString("D6"); }
        }

        public string StatusCancelamentoBaixa
        {
            get { return statusCancelamentoBaixa; }
            set { statusCancelamentoBaixa = PreencherComEspacos(value, 1); }
        }

        public string NumeroItensTitulo
        {
            get { return numeroItensTitulo; }
            set { numeroItensTitulo = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NumeroCheque
        {
            get { return numeroCheque; }
            set { numeroCheque = PreencherComEspacos(value, 20); }
        }

        public string StatusIdentificadorTituloUnico
        {
            get { return statusIdentificadorTituloUnico; }
            set { statusIdentificadorTituloUnico = PreencherComEspacos(value, 1); }
        }

        public ContasReceberDadosPrincipais()
        {
            Identificador = "002001";

            DataBaixaTitulo = string.Empty;
            NumeroAgenciaBancaria = string.Empty;
            NumeroContaBancaria = string.Empty;
            CodigoChamadaSitAdministrativa = "0";
            DataExclusaoTitulo = string.Empty;
            NumeroDocumentoBaixaTitulo = string.Empty;
            NumeroCheque = string.Empty;
        }

    }
}
