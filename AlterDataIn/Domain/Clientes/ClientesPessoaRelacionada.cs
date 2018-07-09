using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesPessoaRelacionada : AlterdataBase
    {
        private string identificador;
        private string codigoChamada;
        private string codigoChamadaPessoaRelacionada;
        private string tipoPessoaRelacionada;
        private string statusPessoaRelacionadaPrincipal;
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

        public string CodigoChamadaPessoaRelacionada
        {
            get { return codigoChamadaPessoaRelacionada; }
            set { codigoChamadaPessoaRelacionada = Convert.ToInt32(value).ToString("D6"); }
        }

        public string TipoPessoaRelacionada
        {
            get { return tipoPessoaRelacionada; }
            set { tipoPessoaRelacionada = PreencherComEspacos(value, 1); }
        }

        public string StatusPessoaRelacionadaPrincipal
        {
            get { return statusPessoaRelacionadaPrincipal; }
            set { statusPessoaRelacionadaPrincipal = PreencherComEspacos(value, 1); }
        }

        public string CnpjCpf
        {
            get { return cnpjCpf; }
            set { cnpjCpf = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 18); }
        }

        public ClientesPessoaRelacionada()
        {
            Identificador = "001006";
        }
    }
}
