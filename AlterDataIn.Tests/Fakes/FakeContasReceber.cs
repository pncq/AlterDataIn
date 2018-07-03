using System;
using AlterDataIn.Domain;
using System.Collections.Generic;
using AlterDataIn.Domain.ContasReceber;

namespace AlterDataIn.Tests.Fakes
{
    using static AlterdataBase;

    public class FakeContasReceber
    {
        public static IEnumerable<ContasReceberDadosPrincipais> RetornaContasReceberDadosPrincipais
        {
            get
            {
                yield return new ContasReceberDadosPrincipais
                {
                    CodigoChamadaPessoas = "0",
                    NumeroTitulo = "123456",
                    NomeTitulo = "RAZÃO SOCIAL LTDA.",
                    DataEmissao = DateTime.Today.ToString("ddMMyyyy"),
                    DataVencimento = new DateTime(DateTime.Today.AddMonths(1).Year, DateTime.Today.AddMonths(1).Month, 5).ToString("ddMMyyyy"),
                    DataDisponivel = string.Empty,
                    ValorTitulo = FormatarMoeda(497.34m),
                    CodigoFebrabanBanco = "0",
                    NumeroTituloBanco = "11223344",
                    ValorBaixaTitulo = FormatarMoeda(0),
                    TipoBaixa = "0",
                    Observacoes = "Observações aqui",
                    IdentificadorTitulo = string.Empty,
                    NumeroAgenciaBancaria = "0102",
                    NumeroContaBancaria = "112233",
                    CategoriaPessoaTitulo = "C",
                    TipoPessoa = "J",
                    CnpjCpfPessoa = "99.999.999/9999-99",
                    CodigoChamadaCentroCusto = "11111",
                    StatusCancelamentoBaixa = "N",
                    NumeroItensTitulo = "1",
                    StatusIdentificadorTituloUnico = "S",

                    CodigoChamadaEmpresa = "1",
                    CodigoChamadaNaturezaLancamento = "000023",
                    CodigoChamadaFormaPagamento = "3",
                    CodigoChamadaAgenciaBanco = "1",
                    CodigoChamadaContaBancaria = "1",
                    CodigoChamadaTipoCobranca = "2"
                };

                yield return new ContasReceberDadosPrincipais
                {
                    CodigoChamadaPessoas = "0",
                    NumeroTitulo = "654321",
                    NomeTitulo = "OUTRA RAZÃO SOCIAL ME.",
                    DataEmissao = DateTime.Today.ToString("ddMMyyyy"),
                    DataVencimento = new DateTime(DateTime.Today.AddMonths(1).Year, DateTime.Today.AddMonths(1).Month, 5).ToString("ddMMyyyy"),
                    DataDisponivel = string.Empty,
                    ValorTitulo = FormatarMoeda(307.94m),
                    CodigoFebrabanBanco = "0",
                    NumeroTituloBanco = "44332211",
                    ValorBaixaTitulo = FormatarMoeda(0),
                    TipoBaixa = "0",
                    Observacoes = string.Empty,
                    IdentificadorTitulo = string.Empty,
                    NumeroAgenciaBancaria = "0204",
                    NumeroContaBancaria = "445566",
                    CategoriaPessoaTitulo = "C",
                    TipoPessoa = "J",
                    CnpjCpfPessoa = "88.888.888/8888-88",
                    CodigoChamadaCentroCusto = "11111",
                    StatusCancelamentoBaixa = "N",
                    NumeroItensTitulo = "1",
                    StatusIdentificadorTituloUnico = "S",

                    CodigoChamadaEmpresa = "1",
                    CodigoChamadaNaturezaLancamento = "000023",
                    CodigoChamadaFormaPagamento = "3",
                    CodigoChamadaAgenciaBanco = "1",
                    CodigoChamadaContaBancaria = "1",
                    CodigoChamadaTipoCobranca = "2"
                };
            }
        }

        public static IEnumerable<ContasReceberItensTitulo> RetornaContasReceberItensTitulo
        {
            get
            {
                yield return new ContasReceberItensTitulo
                {
                    CodigoChamadaCliente = "0",
                    NumeroTitulo = "123456",
                    DataReferencia = DateTime.Today.ToString("ddMMyyyy"),
                    DescricaoItem = "RAZÃO SOCIAL LTDA.",
                    ValorItem = FormatarMoeda(497.34m),
                    IdentificadorTitulo = string.Empty,
                    CodigoChamadaTipoMovimentoCobranca = "0",
                    NumeroItem = "1",

                    CodigoChamadaNaturezaLancamentoIrrf = "259",
                    CodigoChamadaEventoIrrf = "5",
                    ValorIrrf = FormatarMoeda(3m),

                    CodigoChamadaNaturezaLancamentoPis = "257",
                    CodigoChamadaEventoPis = "6",
                    ValorPis = FormatarMoeda(3m),

                    CodigoChamadaNaturezaLancamentoCofins = "258",
                    CodigoChamadaEventoCofins = "7",
                    ValorCofins = FormatarMoeda(3m),

                    CodigoChamadaNaturezaLancamentoCsll = "260",
                    CodigoChamadaEventoCsll = "8",
                    ValorCsll = FormatarMoeda(3m),

                    CodigoChamadaNaturezaLancamentoInss = "261",
                    CodigoChamadaEventoInss = "9",
                    ValorInss = FormatarMoeda(3m),

                    CodigoChamadaNaturezaLancamentoIss = "262",
                    CodigoChamadaEventoIss = "10",
                    ValorIss = FormatarMoeda(3m),

                    //CodigoChamadaNatLancPisCofinsCsll = "",
                    //CodigoChamadaEventoPisCofinsCsll = "",
                    //ValorPisCofinsCsll = "",

                    //CodigoChamadaNaturezaLancamentoOutros = "",
                    //CodigoChamadaEventoOutros = "",
                    //ValorOutros = "",

                    CodigoChamadaNaturezaLancamentoJuros = "8",
                    CodigoChamadaEventoJuros = "2",
                    ValorJuros = FormatarMoeda(3m),

                    //CodigoChamadaNaturezaLancamentoMulta = "",
                    //CodigoChamadaEventoMulta = "",
                    //ValorMulta = "",

                    CodigoChamadaNatLancamentoDesconto = "64",
                    CodigoChamadaEventoDesconto = "11",
                    ValorDesconto = FormatarMoeda(3m)
                };

                yield return new ContasReceberItensTitulo
                {
                    CodigoChamadaCliente = "0",
                    NumeroTitulo = "654321",
                    DataReferencia = DateTime.Today.ToString("ddMMyyyy"),
                    DescricaoItem = "OUTRA RAZÃO SOCIAL ME.",
                    ValorItem = FormatarMoeda(307.94m),
                    IdentificadorTitulo = string.Empty,
                    CodigoChamadaTipoMovimentoCobranca = "0",
                    NumeroItem = "1",

                    CodigoChamadaNaturezaLancamentoIrrf = "259",
                    CodigoChamadaEventoIrrf = "5",
                    ValorIrrf = FormatarMoeda(2m),

                    CodigoChamadaNaturezaLancamentoPis = "257",
                    CodigoChamadaEventoPis = "6",
                    ValorPis = FormatarMoeda(2m),

                    CodigoChamadaNaturezaLancamentoCofins = "258",
                    CodigoChamadaEventoCofins = "7",
                    ValorCofins = FormatarMoeda(2m),

                    CodigoChamadaNaturezaLancamentoCsll = "260",
                    CodigoChamadaEventoCsll = "8",
                    ValorCsll = FormatarMoeda(2m),

                    CodigoChamadaNaturezaLancamentoInss = "261",
                    CodigoChamadaEventoInss = "9",
                    ValorInss = FormatarMoeda(2m),

                    CodigoChamadaNaturezaLancamentoIss = "262",
                    CodigoChamadaEventoIss = "10",
                    ValorIss = FormatarMoeda(2m),

                    CodigoChamadaNaturezaLancamentoJuros = "8",
                    CodigoChamadaEventoJuros = "2",
                    ValorJuros = FormatarMoeda(2m),

                    CodigoChamadaNatLancamentoDesconto = "64",
                    CodigoChamadaEventoDesconto = "11",
                    ValorDesconto = FormatarMoeda(2m)
                };
            }
        }

        public static IEnumerable<ContasReceberRepasse> RetornaContasReceberRepasse
        {
            get
            {
                yield return new ContasReceberRepasse
                {
                    CodigoChamadaEmpresa = "2",
                    CodigoChamadaCliente = "999997",
                    NumeroTitulo = "123456",
                    CodigoReduzidoPessoaRepasse = "1409",
                    BaseCalculoRepasse = FormatarMoeda(1500000.00m),
                    AliquotaRepasse = "0100000",
                    CategoriaPessoaRepasse = "R",
                    IdenificadorTitulo = "RT00000040",
                    NumeroItem = "1"
                };

                yield return new ContasReceberRepasse
                {
                    //CodigoChamadaEmpresa = "2",
                    CodigoChamadaCliente = "999997",
                    NumeroTitulo = "654321",
                    CodigoReduzidoPessoaRepasse = "1410",
                    BaseCalculoRepasse = FormatarMoeda(2000000.00m),
                    AliquotaRepasse = "0100000",
                    CategoriaPessoaRepasse = "R",
                    IdenificadorTitulo = "RT00000040",
                    NumeroItem = "1"
                };
            }
        }

    }
}
