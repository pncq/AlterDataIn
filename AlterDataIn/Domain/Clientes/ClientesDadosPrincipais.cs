using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesDadosPrincipais : AlterdataBase
    {
        private string identificador;
        private string codigoChamda;
        private string nomeCliente;
        private string tipoPessoa;
        private string nomeCurto;
        private string cnpjCpf;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamada
        {
            get { return codigoChamda; }
            set { codigoChamda = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = PreencherComEspacos(value, 50); }
        }

        public string TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = PreencherComEspacos(value, 1); }
        }

        public string NomeCurto
        {
            get { return nomeCurto; }
            set { nomeCurto = PreencherComEspacos(value, 20); }
        }

        public string CnpjCpf
        {
            get { return cnpjCpf; }
            set { cnpjCpf = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 18); }
        }

        public ClientesDadosPrincipais()
        {
            Identificador = "001001";
        }

    }
}
