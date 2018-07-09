using System;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AlterDataIn.Helpers
{
    internal static class Util
    {
        /// <summary>
        /// Isso irá retornar todas as propriedades de cada objeto em questão formatadas
        /// com os seus devidos espaços e pode ser usado de forma implícita.
        /// </summary>
        /// <param name="value">Entidade cujas propriedades serão formatadas</param>
        internal static string FormatarPropriedades(object value)
        {
            var type = value.GetType();
            var flags = BindingFlags.Public | BindingFlags.Instance;
            var properties = type.GetProperties(flags);

            var sb = new StringBuilder();
            foreach (var prop in properties.Select(pi => pi.GetValue(value, null)))
            {
                if (!IsNull(prop?.ToString()))
                {
                    sb.Append(prop + Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        internal static bool IsNull(string value) => string.IsNullOrWhiteSpace(value);

    }
}
