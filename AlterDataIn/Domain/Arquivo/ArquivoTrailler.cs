using System;

namespace AlterDataIn.Domain.Arquivo
{
    public sealed class ArquivoTrailler : AlterdataBase
    {
        private string identificador;
        private string dataArquivo;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string DataArquivo
        {
            get { return dataArquivo; }
            set { dataArquivo = PreencherComEspacos(value, 8); }
        }

        public ArquivoTrailler()
        {
            Identificador = new string('9', 6);
            DataArquivo = DateTime.Today.ToString("ddMMyyyy");
        }
    }
}
