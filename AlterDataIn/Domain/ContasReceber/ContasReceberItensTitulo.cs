using System;
using System.Text.RegularExpressions;

namespace AlterDataIn.Domain.ContasReceber
{
    public sealed class ContasReceberItensTitulo : AlterdataBase
    {
        private string identificador;
        private string codigoChamadaEmpresa;
        private string codigoChamadaCliente;
        private string numeroTitulo;
        private string dataReferencia;
        private string descricaoItem;
        private string valorItem;
        private string identificadorTitulo;
        private string codigoChamadaTipoMovimentoCobranca;
        private string numeroItem;
        private string codigoChamadaNaturezaLancamentoIrrf;
        private string codigoChamadaEventoIrrf;
        private string valorIrrf;
        private string codigoChamadaNaturezaLancamentoPis;
        private string codigoChamadaEventoPis;
        private string valorPis;
        private string codigoChamadaNaturezaLancamentoCofins;
        private string codigoChamadaEventoCofins;
        private string valorCofins;
        private string codigoChamadaNaturezaLancamentoCsll;
        private string codigoChamadaEventoCsll;
        private string valorCsll;
        private string codigoChamadaNaturezaLancamentoInss;
        private string codigoChamadaEventoInss;
        private string valorInss;
        private string codigoChamadaNaturezaLancamentoIss;
        private string codigoChamadaEventoIss;
        private string valorIss;
        private string codigoChamadaNatLancPisCofinsCsll;
        private string codigoChamadaEventoPisCofinsCsll;
        private string valorPisCofinsCsll;
        private string codigoChamadaNaturezaLancamentoOutros;
        private string codigoChamadaEventoOutros;
        private string valorOutros;
        private string codigoChamadaNaturezaLancamentoJuros;
        private string codigoChamadaEventoJuros;
        private string valorJuros;
        private string codigoChamadaNaturezaLancamentoMulta;
        private string codigoChamadaEventoMulta;
        private string valorMulta;
        private string codigoChamadaNatLancamentoDesconto;
        private string codigoChamadaEventoDesconto;
        private string valorDesconto;

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

        public string DataReferencia
        {
            get { return dataReferencia; }
            set { dataReferencia = PreencherComEspacos(value, 8); }
        }

        public string DescricaoItem
        {
            get { return descricaoItem; }
            set { descricaoItem = PreencherComEspacos(value, 50); }
        }

        public string ValorItem
        {
            get { return valorItem; }
            set { valorItem = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string IdentificadorTitulo
        {
            get { return identificadorTitulo; }
            set { identificadorTitulo = PreencherComEspacos(value, 10); }
        }

        public string CodigoChamadaTipoMovimentoCobranca
        {
            get { return codigoChamadaTipoMovimentoCobranca; }
            set { codigoChamadaTipoMovimentoCobranca = Convert.ToInt32(value).ToString("D6"); }
        }

        public string NumeroItem
        {
            get { return numeroItem; }
            set { numeroItem = Convert.ToInt32(value).ToString("D10"); }
        }

        public string CodigoChamadaNaturezaLancamentoIrrf
        {
            get { return codigoChamadaNaturezaLancamentoIrrf; }
            set { codigoChamadaNaturezaLancamentoIrrf = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoIrrf
        {
            get { return codigoChamadaEventoIrrf; }
            set { codigoChamadaEventoIrrf = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorIrrf
        {
            get { return valorIrrf; }
            set { valorIrrf = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoPis
        {
            get { return codigoChamadaNaturezaLancamentoPis; }
            set { codigoChamadaNaturezaLancamentoPis = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoPis
        {
            get { return codigoChamadaEventoPis; }
            set { codigoChamadaEventoPis = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorPis
        {
            get { return valorPis; }
            set { valorPis = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoCofins
        {
            get { return codigoChamadaNaturezaLancamentoCofins; }
            set { codigoChamadaNaturezaLancamentoCofins = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoCofins
        {
            get { return codigoChamadaEventoCofins; }
            set { codigoChamadaEventoCofins = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorCofins
        {
            get { return valorCofins; }
            set { valorCofins = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoCsll
        {
            get { return codigoChamadaNaturezaLancamentoCsll; }
            set { codigoChamadaNaturezaLancamentoCsll = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoCsll
        {
            get { return codigoChamadaEventoCsll; }
            set { codigoChamadaEventoCsll = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorCsll
        {
            get { return valorCsll; }
            set { valorCsll = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoInss
        {
            get { return codigoChamadaNaturezaLancamentoInss; }
            set { codigoChamadaNaturezaLancamentoInss = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoInss
        {
            get { return codigoChamadaEventoInss; }
            set { codigoChamadaEventoInss = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorInss
        {
            get { return valorInss; }
            set { valorInss = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoIss
        {
            get { return codigoChamadaNaturezaLancamentoIss; }
            set { codigoChamadaNaturezaLancamentoIss = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoIss
        {
            get { return codigoChamadaEventoIss; }
            set { codigoChamadaEventoIss = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorIss
        {
            get { return valorIss; }
            set { valorIss = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNatLancPisCofinsCsll
        {
            get { return codigoChamadaNatLancPisCofinsCsll; }
            set { codigoChamadaNatLancPisCofinsCsll = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoPisCofinsCsll
        {
            get { return codigoChamadaEventoPisCofinsCsll; }
            set { codigoChamadaEventoPisCofinsCsll = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorPisCofinsCsll
        {
            get { return valorPisCofinsCsll; }
            set { valorPisCofinsCsll = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoOutros
        {
            get { return codigoChamadaNaturezaLancamentoOutros; }
            set { codigoChamadaNaturezaLancamentoOutros = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoOutros
        {
            get { return codigoChamadaEventoOutros; }
            set { codigoChamadaEventoOutros = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorOutros
        {
            get { return valorOutros; }
            set { valorOutros = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoJuros
        {
            get { return codigoChamadaNaturezaLancamentoJuros; }
            set { codigoChamadaNaturezaLancamentoJuros = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoJuros
        {
            get { return codigoChamadaEventoJuros; }
            set { codigoChamadaEventoJuros = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorJuros
        {
            get { return valorJuros; }
            set { valorJuros = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNaturezaLancamentoMulta
        {
            get { return codigoChamadaNaturezaLancamentoMulta; }
            set { codigoChamadaNaturezaLancamentoMulta = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoMulta
        {
            get { return codigoChamadaEventoMulta; }
            set { codigoChamadaEventoMulta = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorMulta
        {
            get { return valorMulta; }
            set { valorMulta = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public string CodigoChamadaNatLancamentoDesconto
        {
            get { return codigoChamadaNatLancamentoDesconto; }
            set { codigoChamadaNatLancamentoDesconto = Convert.ToInt32(value).ToString("D6"); }
        }

        public string CodigoChamadaEventoDesconto
        {
            get { return codigoChamadaEventoDesconto; }
            set { codigoChamadaEventoDesconto = Convert.ToInt32(value).ToString("D6"); }
        }

        public string ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = PreencherComEspacos(Regex.Replace(value, "[^0-9]", ""), 14); }
        }

        public ContasReceberItensTitulo()
        {
            Identificador = "002002";
            CodigoChamadaEmpresa = "1";

            CodigoChamadaNaturezaLancamentoIrrf = "0";
            CodigoChamadaNaturezaLancamentoPis = "0";
            CodigoChamadaNaturezaLancamentoCofins = "0";
            CodigoChamadaNaturezaLancamentoCsll = "0";
            CodigoChamadaNaturezaLancamentoInss = "0";
            CodigoChamadaNaturezaLancamentoIss = "0";
            CodigoChamadaNatLancPisCofinsCsll = "0";
            CodigoChamadaNaturezaLancamentoOutros = "0";
            CodigoChamadaNaturezaLancamentoJuros = "0";
            CodigoChamadaNaturezaLancamentoMulta = "0";
            CodigoChamadaNatLancamentoDesconto = "0";

            CodigoChamadaEventoIrrf = "0";
            CodigoChamadaEventoPis = "0";
            CodigoChamadaEventoCofins = "0";
            CodigoChamadaEventoCsll = "0";
            CodigoChamadaEventoInss = "0";
            CodigoChamadaEventoIss = "0";
            CodigoChamadaEventoPisCofinsCsll = "0";
            CodigoChamadaEventoOutros = "0";
            CodigoChamadaEventoJuros = "0";
            CodigoChamadaEventoMulta = "0";
            CodigoChamadaEventoDesconto = "0";

            ValorIrrf = FormatarMoeda(0);
            ValorPis = FormatarMoeda(0);
            ValorCofins = FormatarMoeda(0);
            ValorCsll = FormatarMoeda(0);
            ValorInss = FormatarMoeda(0);
            ValorIss = FormatarMoeda(0);
            ValorPisCofinsCsll = FormatarMoeda(0);
            ValorOutros = FormatarMoeda(0);
            ValorJuros = FormatarMoeda(0);
            ValorMulta = FormatarMoeda(0);
            ValorDesconto = FormatarMoeda(0);
        }

    }
}
