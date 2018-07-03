using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesDadosComplementares : AlterdataBase
    {
        private string identificador;
        private string codigoChamada;
        private string sexo;
        private string dataNascimento;
        private string identidade;
        private string orgaoExpedidor;
        private string nacionalidade;
        private string ufNaturalidade;
        private string profissao;
        private string estadoCivil;
        private string nomePai;
        private string nomeMae;
        private string numeroCtps;
        private string ramoAtividade;
        private string inicioAtividade;
        private string registroJuntaComercial;
        private string registroCivil;
        private string capitalRegistrado;
        private string capitalAtual;
        private string capitalGiro;
        private string valorEstoque;
        private string faturamentoAnual;
        private string numeroFuncionarios;
        private string cadastradoEm;
        private string valorLimiteCredito;
        private string observacao;
        private string codigoChamadaTransportador;
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

        public string Sexo
        {
            get { return sexo; }
            set { sexo = PreencherComEspacos(value, 1); }
        }

        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = PreencherComEspacos(value, 8); }
        }

        public string Identidade
        {
            get { return identidade; }
            set { identidade = PreencherComEspacos(value, 20); }
        }

        public string OrgaoExpedidor
        {
            get { return orgaoExpedidor; }
            set { orgaoExpedidor = PreencherComEspacos(value, 20); }
        }

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = PreencherComEspacos(value, 20); }
        }

        public string UfNaturalidade
        {
            get { return ufNaturalidade; }
            set { ufNaturalidade = PreencherComEspacos(value, 2); }
        }

        public string Profissao
        {
            get { return profissao; }
            set { profissao = PreencherComEspacos(value, 20); }
        }

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = PreencherComEspacos(value, 1); }
        }

        public string NomePai
        {
            get { return nomePai; }
            set { nomePai = PreencherComEspacos(value, 50); }
        }

        public string NomeMae
        {
            get { return nomeMae; }
            set { nomeMae = PreencherComEspacos(value, 50); }
        }

        public string NumeroCtps
        {
            get { return numeroCtps; }
            set { numeroCtps = PreencherComEspacos(value, 10); }
        }

        public string RamoAtividade
        {
            get { return ramoAtividade; }
            set { ramoAtividade = PreencherComEspacos(value, 50); }
        }

        public string InicioAtividade
        {
            get { return inicioAtividade; }
            set { inicioAtividade = PreencherComEspacos(value, 8); }
        }

        public string RegistroJustaComercial
        {
            get { return registroJuntaComercial; }
            set { registroJuntaComercial = PreencherComEspacos(value, 20); }
        }

        public string RegistroCivil
        {
            get { return registroCivil; }
            set { registroCivil = PreencherComEspacos(value, 20); }
        }

        public string CapitalRegistrado
        {
            get { return capitalRegistrado; }
            set { capitalRegistrado = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CapitalAtual
        {
            get { return capitalAtual; }
            set { capitalAtual = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CapitalGiro
        {
            get { return capitalGiro; }
            set { capitalGiro = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string ValorEstoque
        {
            get { return valorEstoque; }
            set { valorEstoque = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string FaturamentoAnual
        {
            get { return faturamentoAnual; }
            set { faturamentoAnual = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string NumeroFuncionarios
        {
            get { return numeroFuncionarios; }
            set { numeroFuncionarios = Convert.ToInt32(value).ToString("D5"); }
        }

        public string CadastradoEm
        {
            get { return cadastradoEm; }
            set { cadastradoEm = PreencherComEspacos(value, 8); }
        }

        public string ValorLimiteCredito
        {
            get { return valorLimiteCredito; }
            set { valorLimiteCredito = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = PreencherComEspacos(value, 200); }
        }

        public string CodigoChamadaTransportador
        {
            get { return codigoChamadaTransportador; }
            set { codigoChamadaTransportador = PreencherComEspacos(value, 6); }
        }

        public string CnpjCpf
        {
            get { return cnpjCpf; }
            set { cnpjCpf = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 18); }
        }

        public ClientesDadosComplementares()
        {
            Identificador = "001004";
        }
    }
}
