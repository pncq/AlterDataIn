using System;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AlterDataIn.Domain.ContasReceber
{
    public class ContasReceber : AlterdataBase
    {
        public ContasReceberHeader ContasReceberHeader { get; set; }
        public ContasReceberDadosPrincipais ContasReceberDadosPrincipais { get; set; }
        public ContasReceberItensTitulo ContasReceberItensTitulo { get; set; }
        public ContasReceberRepasse ContasReceberRepasse { get; set; }
        public ContasReceberHeaderTrailler ContasReceberHeaderTrailler { get; set; }

        /// <summary>
        /// Isso irá retornar todas as propriedades de cada objeto em questão formatadas
        /// com os seus devidos espaços e pode ser usado de forma implícita.
        /// </summary>
        public override string ToString()
        {
            var type = GetType();
            var flags = BindingFlags.Public | BindingFlags.Instance;
            var properties = type.GetProperties(flags);

            var sb = new StringBuilder();
            foreach (var prop in properties.Select(pi => pi.GetValue(this, null)))
            {
                if (!IsNull(prop?.ToString()))
                {
                    sb.Append(prop + Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retorna um cabeçalho para o objeto <see cref="ContasReceber"/>
        /// </summary>
        public static string GetHeader => new ContasReceberHeader().ToString();

        /// <summary>
        /// Retorna um trailler para o objeto <see cref="ContasReceber"/>
        /// </summary>
        public static string GetTrailler => new ContasReceberHeaderTrailler().ToString();

    }
}
