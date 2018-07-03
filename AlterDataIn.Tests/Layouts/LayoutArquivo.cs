using Xunit;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AlterDataIn.Domain.Arquivo;

namespace AlterDataIn.Tests.Layouts
{
    public class LayoutArquivo
    {
        [Fact]
        public async Task Arquivo_Teste()
        {
            var filename = $"{nameof(Arquivo_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
999999{0}", DateTime.Today.ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(Helper.PASTA_IMPORTACAO));

            var file = Path.Combine(Helper.PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));
        }
    }
}
