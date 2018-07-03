using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.ContasReceber
{
    public sealed class ContasReceberRepasse : AlterdataBase
    {
        private string identificador;
        private string codigoChamadaEmpresa;
        private string codigoChamadaCliente;
        private string numeroTitulo;
        private string codigoReduzidoPessoaRepasse;
        private string baseCalculoRepasse;
        private string aliquotaRepasse;
        private string categoriaPessoaRepasse;
        private string idenificadorTitulo;
        private string numeroItem;

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

        public string CodigoChamadaCliente
        {
            get { return codigoChamadaCliente; }
            set { codigoChamadaCliente = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NumeroTitulo
        {
            get { return numeroTitulo; }
            set { numeroTitulo = PreencherComEspacos(value, 20); }
        }

        public string CodigoReduzidoPessoaRepasse
        {
            get { return codigoReduzidoPessoaRepasse; }
            set { codigoReduzidoPessoaRepasse = Convert.ToInt32(value).ToString("D6"); }
        }

        public string BaseCalculoRepasse
        {
            get { return baseCalculoRepasse; }
            set { baseCalculoRepasse = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string AliquotaRepasse
        {
            get { return aliquotaRepasse; }
            set { aliquotaRepasse = Convert.ToInt32(value).ToString("D7"); }
        }

        public string CategoriaPessoaRepasse
        {
            get { return categoriaPessoaRepasse; }
            set { categoriaPessoaRepasse = PreencherComEspacos(value, 1); }
        }

        public string IdenificadorTitulo
        {
            get { return idenificadorTitulo; }
            set { idenificadorTitulo = PreencherComEspacos(value, 10); }
        }

        public string NumeroItem
        {
            get { return numeroItem; }
            set { numeroItem = Convert.ToInt32(value).ToString("D10"); }
        }

        public ContasReceberRepasse()
        {
            Identificador = "002003";
            CodigoChamadaEmpresa = "1";
        }
    }
}
