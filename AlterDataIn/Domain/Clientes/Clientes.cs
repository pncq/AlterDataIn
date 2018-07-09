using AlterDataIn.Helpers;

namespace AlterDataIn.Domain.Clientes
{
    public sealed class Clientes : AlterdataBase
    {
        public ClientesHeader ClientesHeader { get; set; }
        public ClientesDadosPrincipais ClientesDadosPrincipais { get; set; }
        public ClientesEnderecos ClientesEnderecos { get; set; }
        public ClientesComplementoEndereco ClientesComplementoEndereco { get; set; }
        public ClientesDadosComplementares ClientesDadosComplementares { get; set; }
        public ClientesCaracteristicas ClientesCaracteristicas { get; set; }
        public ClientesPessoaRelacionada ClientesPessoaRelacionada { get; set; }
        public ClientesTrailler ClientesTrailler { get; set; }

        public override string ToString() => Util.FormatarPropriedades(this);

        /// <summary>
        /// Retorna um cabeçalho para o objeto <see cref="Clientes"/>
        /// </summary>
        public static string GetHeader => new ClientesHeader().ToString();

        /// <summary>
        /// Retorna um trailler para o objeto <see cref="Clientes"/>
        /// </summary>
        public static string GetTrailler => new ClientesTrailler().ToString();

    }
}
