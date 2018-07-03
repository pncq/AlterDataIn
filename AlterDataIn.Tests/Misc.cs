using Xunit;
using System;
using AlterDataIn.Domain;

namespace AlterDataIn.Tests
{
    public class Misc
    {
        [Fact]
        public void Formatar_Valores_Teste()
        {
            // Arrange
            var valor = 497.34m;
            var expected = "00000004973400";

            // Act
            var actual = AlterdataBase.FormatarMoeda(valor);

            // Assert
            Assert.Equal(expected, actual.Replace(".", ""));
        }

        [Fact]
        public void Valor_Padrao_Propriedade_Teste()
        {
            // Arrange
            var pessoa = new Pessoa();

            // Act
            var actual = pessoa.ToString();

            // Assert
            Assert.Equal("     00", actual);
        }
    }

    internal class Pessoa : AlterdataBase
    {
        private string nome;
        private string idade;

        public string Nome
        {
            get { return nome; }
            set { nome = PreencherComEspacos(value, 5); }
        }

        public string Idade
        {
            get { return idade; }
            set { idade = Convert.ToInt32(value).ToString("D2"); }
        }

        public Pessoa()
        {
            Nome = null;
            Idade = "0";
        }
    }
}
