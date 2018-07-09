using Xunit;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlterDataIn.Tests.Fakes;
using AlterDataIn.Domain.Arquivo;
using AlterDataIn.Domain.ContasReceber;

namespace AlterDataIn.Tests.Layouts
{
    using static Helper;
    using static DateTime;
    using static FakeContasReceber;

    public class LayoutContasReceber
    {
        [Fact]
        public async Task Contas_Receber_Dados_Principais_Teste()
        {
            var filename = $"{nameof(Contas_Receber_Dados_Principais_Teste)}.erp";
            var conteudo = new StringBuilder();
            var vencimento = Today.AddMonths(1);

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(ContasReceber.GetHeader);

            conteudo.AppendLine(RetornaContasReceberDadosPrincipais.First());

            conteudo.AppendLine(ContasReceber.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
002000ARECEBER
002001000001000000123456              RAZÃO SOCIAL LTDA.                                {0}{1}        0000000497340000002300000300000000100000111223344                                          000002        000000000000000Observações aqui                                                                                                                                                                                                  0102      112233              CJ99999999999999    000000                                                          011111N000001                    S
002999{0}
999999{0}", Today.ToString("ddMMyyyy"), new DateTime(vencimento.Year, vencimento.Month, 5).ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(PASTA_IMPORTACAO));

            var file = Path.Combine(PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));
        }

        [Fact]
        public async Task Contas_Receber_Itens_Titulo_Teste()
        {
            var filename = $"{nameof(Contas_Receber_Itens_Titulo_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(ContasReceber.GetHeader);

            conteudo.AppendLine(RetornaContasReceberItensTitulo.First());

            conteudo.AppendLine(ContasReceber.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
002000ARECEBER
002002000001000000123456              {0}RAZÃO SOCIAL LTDA.                                00000004973400          00000000000000010002590000050000000003000000025700000600000000030000000258000007000000000300000002600000080000000003000000026100000900000000030000000262000010000000000300000000000000000000000000000000000000000000000000000000000008000002000000000300000000000000000000000000000000006400001100000000030000
002999{0}
999999{0}", Today.ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(PASTA_IMPORTACAO));

            var file = Path.Combine(PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));
        }

        [Fact]
        public async Task Contas_Receber_Repasse_Teste()
        {
            var filename = $"{nameof(Contas_Receber_Repasse_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(ContasReceber.GetHeader);

            conteudo.AppendLine(RetornaContasReceberRepasse.First());

            conteudo.AppendLine(ContasReceber.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
002000ARECEBER
002003000002999997123456              001409000150000000000100000RRT000000400000000001
002999{0}
999999{0}", Today.ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(PASTA_IMPORTACAO));

            var file = Path.Combine(PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));
        }

        [Fact]
        public async Task Contas_Receber_Completo_Teste()
        {
            var filename = $"{nameof(Contas_Receber_Completo_Teste)}.erp";
            var conteudo = new StringBuilder();
            var vencimento = Today.AddMonths(1);

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(ContasReceber.GetHeader);

            RetornaContasReceberDadosPrincipais.ForEach(c => conteudo.AppendLine(c));
            RetornaContasReceberItensTitulo.ForEach(c => conteudo.AppendLine(c));
            RetornaContasReceberRepasse.ForEach(c => conteudo.AppendLine(c));

            conteudo.AppendLine(ContasReceber.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
002000ARECEBER
002001000001000000123456              RAZÃO SOCIAL LTDA.                                {0}{1}        0000000497340000002300000300000000100000111223344                                          000002        000000000000000Observações aqui                                                                                                                                                                                                  0102      112233              CJ99999999999999    000000                                                          011111N000001                    S
002001000001000000654321              OUTRA RAZÃO SOCIAL ME.                            {0}{1}        0000000307940000002300000300000000100000144332211                                          000002        000000000000000                                                                                                                                                                                                                  0204      445566              CJ88888888888888    000000                                                          011111N000001                    S
002002000001000000123456              {0}RAZÃO SOCIAL LTDA.                                00000004973400          00000000000000010002590000050000000003000000025700000600000000030000000258000007000000000300000002600000080000000003000000026100000900000000030000000262000010000000000300000000000000000000000000000000000000000000000000000000000008000002000000000300000000000000000000000000000000006400001100000000030000
002002000001000000654321              {0}OUTRA RAZÃO SOCIAL ME.                            00000003079400          00000000000000010002590000050000000002000000025700000600000000020000000258000007000000000200000002600000080000000002000000026100000900000000020000000262000010000000000200000000000000000000000000000000000000000000000000000000000008000002000000000200000000000000000000000000000000006400001100000000020000
002003000002999997123456              001409000150000000000100000RRT000000400000000001
002003000001999997654321              001410000200000000000100000RRT000000400000000001
002999{0}
999999{0}", Today.ToString("ddMMyyyy"), new DateTime(vencimento.Year, vencimento.Month, 5).ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(PASTA_IMPORTACAO));

            var file = Path.Combine(PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));
        }

        [Fact]
        public async Task Contas_Receber_Completo_Por_Conta_Teste()
        {
            var filename = $"{nameof(Contas_Receber_Completo_Por_Conta_Teste)}.erp";
            var conteudo = new StringBuilder();
            var vencimento = Today.AddMonths(1);

            conteudo.AppendLine(Arquivo.GetHeader);
            //conteudo.AppendLine(ContasReceber.GetHeader);

            conteudo.Append(new ContasReceber
            {
                ContasReceberHeader = new ContasReceberHeader(),
                ContasReceberDadosPrincipais = RetornaContasReceberDadosPrincipais.First(),
                ContasReceberItensTitulo = RetornaContasReceberItensTitulo.First(),
                ContasReceberRepasse = RetornaContasReceberRepasse.First(),
                ContasReceberTrailler = new ContasReceberTrailler()
            });

            conteudo.Append(new ContasReceber
            {
                ContasReceberHeader = new ContasReceberHeader(),
                ContasReceberDadosPrincipais = RetornaContasReceberDadosPrincipais.Last(),
                ContasReceberItensTitulo = RetornaContasReceberItensTitulo.Last(),
                ContasReceberRepasse = RetornaContasReceberRepasse.Last(),
                ContasReceberTrailler = new ContasReceberTrailler()
            });

            //conteudo.AppendLine(ContasReceber.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
002000ARECEBER
002001000001000000123456              RAZÃO SOCIAL LTDA.                                {0}{1}        0000000497340000002300000300000000100000111223344                                          000002        000000000000000Observações aqui                                                                                                                                                                                                  0102      112233              CJ99999999999999    000000                                                          011111N000001                    S
002002000001000000123456              {0}RAZÃO SOCIAL LTDA.                                00000004973400          00000000000000010002590000050000000003000000025700000600000000030000000258000007000000000300000002600000080000000003000000026100000900000000030000000262000010000000000300000000000000000000000000000000000000000000000000000000000008000002000000000300000000000000000000000000000000006400001100000000030000
002003000002999997123456              001409000150000000000100000RRT000000400000000001
002999{0}
002000ARECEBER
002001000001000000654321              OUTRA RAZÃO SOCIAL ME.                            {0}{1}        0000000307940000002300000300000000100000144332211                                          000002        000000000000000                                                                                                                                                                                                                  0204      445566              CJ88888888888888    000000                                                          011111N000001                    S
002002000001000000654321              {0}OUTRA RAZÃO SOCIAL ME.                            00000003079400          00000000000000010002590000050000000002000000025700000600000000020000000258000007000000000200000002600000080000000002000000026100000900000000020000000262000010000000000200000000000000000000000000000000000000000000000000000000000008000002000000000200000000000000000000000000000000006400001100000000020000
002003000001999997654321              001410000200000000000100000RRT000000400000000001
002999{0}
999999{0}", Today.ToString("ddMMyyyy"), new DateTime(vencimento.Year, vencimento.Month, 5).ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(PASTA_IMPORTACAO));

            var file = Path.Combine(PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));

        }

    }
}
