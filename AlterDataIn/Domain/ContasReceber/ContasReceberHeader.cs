using System;

namespace AlterDataIn.Domain.ContasReceber
{
    public sealed class ContasReceberHeader : AlterdataBase
    {
        private string identificador;
        private string identificadorContasReceber;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string IdentificadorContasReceber
        {
            get { return identificadorContasReceber; }
            set { identificadorContasReceber = PreencherComEspacos(value, 8); }
        }

        public ContasReceberHeader()
        {
            Identificador = "002000";
            IdentificadorContasReceber = "ARECEBER";
        }

    }
}
