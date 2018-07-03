using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesEnderecos : AlterdataBase
    {
        private string identificador;
        private string codigoChamada;
        private string nomeCliente;
        private string nascimentoInicioAtividade;
        private string cnpjCpf;
        private string inscricaoEstadual;
        private string inscricaoMunicipal;
        private string suframa;
        private string logradouro;
        private string numeroLogradouro;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private string sequencialEndereco;
        private string enderecoAtivo;
        private string tipoLogradouro;

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

        public string NascimentoInicioAtividade
        {
            get { return nascimentoInicioAtividade; }
            set { nascimentoInicioAtividade = PreencherComEspacos(value, 8); }
        }

        public string CnpjCpf
        {
            get { return cnpjCpf; }
            set { cnpjCpf = PreencherComEspacos(Regex.Replace(value ?? string.Empty, "[^0-9]", ""), 18); }
        }

        public string InscricaoEstadual
        {
            get { return inscricaoEstadual; }
            set { inscricaoEstadual = PreencherComEspacos(Regex.Replace(value ?? string.Empty, "[^0-9]", ""), 18); }
        }

        public string InscricaoMunicipal
        {
            get { return inscricaoMunicipal; }
            set { inscricaoMunicipal = PreencherComEspacos(Regex.Replace(value ?? string.Empty, "[^0-9]", ""), 20); }
        }

        public string Suframa
        {
            get { return suframa; }
            set { suframa = PreencherComEspacos(Regex.Replace(value ?? string.Empty, "[^0-9]", ""), 20); }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = PreencherComEspacos(value, 50); }
        }

        public string NumeroLogradouro
        {
            get { return numeroLogradouro; }
            set { numeroLogradouro = PreencherComEspacos(value, 10); }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = PreencherComEspacos(value, 50); }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = PreencherComEspacos(value, 50); }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = PreencherComEspacos(value, 50); }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = PreencherComEspacos(value, 2); }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = PreencherComEspacos(Regex.Replace(value ?? string.Empty, "[^0-9]", ""), 9); }
        }

        /// <summary>
        /// Deve ser 01 para endereço principal e deve ser incrementado para endereços adicionais
        /// </summary>
        public string SequencialEndereco
        {
            get { return sequencialEndereco; }
            set { sequencialEndereco = Convert.ToInt32(value).ToString("D2"); }
        }

        public string EnderecoAtivo
        {
            get { return enderecoAtivo; }
            set { enderecoAtivo = PreencherComEspacos(value, 1); }
        }

        public string TipoLogradouro
        {
            get { return tipoLogradouro; }
            set { tipoLogradouro = PreencherComEspacos(value, 5); }
        }

        public ClientesEnderecos()
        {
            Identificador = "001002";
            SequencialEndereco = "01";
        }

    }
}
