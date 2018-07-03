using System;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesTrailler : AlterdataBase
    {
        private string identificador;
        private string dataDados;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string DataDados
        {
            get { return dataDados; }
            set { dataDados = PreencherComEspacos(value, 8); }
        }

        public ClientesTrailler()
        {
            Identificador = "001999";
            DataDados = DateTime.Today.ToString("ddMMyyyy");
        }

    }
}
