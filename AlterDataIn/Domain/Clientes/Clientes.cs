using System;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AlterDataIn.Domain.Clientes
{
    public class Clientes : AlterdataBase
    {
        public ClientesHeader ClientesHeader { get; set; }
        public ClientesDadosPrincipais ClientesDadosPrincipais { get; set; }
        public ClientesEnderecos ClientesEnderecos { get; set; }
        public ClientesComplementoEndereco ClientesComplementoEndereco { get; set; }
        public ClientesDadosComplementares ClientesDadosComplementares { get; set; }
        public ClientesTrailler ClientesTrailler { get; set; }

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
        /// Retorna um cabeçalho para o objeto <see cref="Clientes"/>
        /// </summary>
        public static string GetHeader => new ClientesHeader().ToString();

        /// <summary>
        /// Retorna um trailler para o objeto <see cref="Clientes"/>
        /// </summary>
        public static string GetTrailler => new ClientesTrailler().ToString();

    }
}
