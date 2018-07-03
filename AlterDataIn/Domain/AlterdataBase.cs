using System.Linq;
using System.Reflection;
using System.Globalization;

namespace AlterDataIn.Domain
{
    public abstract class AlterdataBase
    {
        /// <summary>
        /// Formata um valor decimal de acordo com a regra de negócio
        /// </summary>
        /// <param name="value">O valor a ser formatado</param>
        public static string FormatarMoeda(decimal value)
        {
            var format = new string('0', 14).Insert(10, ".");
            return value.ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Isso irá retornar todas as propriedades do objeto em questão formatadas
        /// com os seus devidos espaços e pode ser usado de forma implícita.
        /// </summary>
        public override string ToString()
        {
            var type = GetType();
            var flags = BindingFlags.Public | BindingFlags.Instance;
            var properties = type.GetProperties(flags);

            return string.Concat(properties.Select(pi => pi.GetValue(this, null)));
        }

        protected static string PreencherComEspacos(string value, int length)
        {
            return value == null
                ? new string(' ', length)
                : value.Length > length
                    ? value.Substring(0, length)
                    : value + new string(' ', length - value.Length);
        }

        protected static bool IsNull(string value) => string.IsNullOrWhiteSpace(value);
    }
}
