﻿using System;

namespace AlterDataIn.Domain.ContasReceber
{
    public sealed class ContasReceberHeaderTrailler : AlterdataBase
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

        public ContasReceberHeaderTrailler()
        {
            Identificador = "002999";
            DataDados = DateTime.Today.ToString("ddMMyyyy");
        }
    }
}
