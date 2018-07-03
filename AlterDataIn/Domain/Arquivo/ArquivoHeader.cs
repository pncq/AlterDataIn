using System;

namespace AlterDataIn.Domain.Arquivo
{
    public sealed class ArquivoHeader : AlterdataBase
    {
        private string identificador;
        private string identificadorAlterdata;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string IdentificadorAlterdata
        {
            get { return identificadorAlterdata; }
            set { identificadorAlterdata = PreencherComEspacos(value, 9); }
        }

        public ArquivoHeader()
        {
            Identificador = new string('0', 6);
            IdentificadorAlterdata = "ALTERDATA";
        }
    }
}
