using AlterDataIn.Helpers;

namespace AlterDataIn.Domain.ContasReceber
{
    public sealed class ContasReceber : AlterdataBase
    {
        public ContasReceberHeader ContasReceberHeader { get; set; }
        public ContasReceberDadosPrincipais ContasReceberDadosPrincipais { get; set; }
        public ContasReceberItensTitulo ContasReceberItensTitulo { get; set; }
        public ContasReceberRepasse ContasReceberRepasse { get; set; }
        public ContasReceberTrailler ContasReceberTrailler { get; set; }

        public override string ToString() => Util.FormatarPropriedades(this);

        /// <summary>
        /// Retorna um cabeçalho para o objeto <see cref="ContasReceber"/>
        /// </summary>
        public static string GetHeader => new ContasReceberHeader().ToString();

        /// <summary>
        /// Retorna um trailler para o objeto <see cref="ContasReceber"/>
        /// </summary>
        public static string GetTrailler => new ContasReceberTrailler().ToString();

    }
}
