using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class ClientesCaracteristicas : AlterdataBase
    {
        private string identificador;
        private string codigoChamada;
        private string codigoCaracteristica;
        private string descricaoCaracteristica;
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

        public string CodigoCaracteristica
        {
            get { return codigoCaracteristica; }
            set { codigoCaracteristica = Convert.ToInt32(value).ToString("D6"); }
        }

        public string DescricaoCaracteristica
        {
            get { return descricaoCaracteristica; }
            set { descricaoCaracteristica = PreencherComEspacos(value, 20); }
        }

        public string CnpjCpf
        {
            get { return cnpjCpf; }
            set { cnpjCpf = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 18); }
        }

        public ClientesCaracteristicas()
        {
            Identificador = "001005";
        }

    }
}
