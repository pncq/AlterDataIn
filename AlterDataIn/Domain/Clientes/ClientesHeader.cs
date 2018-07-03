using System;

namespace AlterDataIn.Domain.Clientes
{
   public sealed class ClientesHeader : AlterdataBase
    {
        private string identificador;
        private string identidicadorClientes;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = Convert.ToInt32(value).ToString("D6"); }
        }

        public string IdentificadorClientes
        {
            get { return identidicadorClientes; }
            set { identidicadorClientes = PreencherComEspacos(value, 8); }
        }

        public ClientesHeader()
        {
            Identificador = "001000";
            IdentificadorClientes = "CLIENTES";
        }

    }
}
