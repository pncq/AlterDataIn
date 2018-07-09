using System;
using System.Text;
using System.Collections.Generic;

namespace AlterDataIn.Tests
{
    public static class ExtensionMethods
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }

        public static void AppendLine(this StringBuilder sb, object value)
            => sb.AppendLine(value.ToString());
    }
}
