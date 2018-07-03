namespace AlterDataIn.Domain.Arquivo
{
    public class Arquivo
    {
        public ArquivoHeader ArquivoHeader { get; set; }
        public ArquivoTrailler ArquivoTrailler { get; set; }

        /// <summary>
        /// Retorna um cabeçalho para o objeto <see cref="Arquivo"/>
        /// </summary>
        public static string GetHeader => new ArquivoHeader().ToString();

        /// <summary>
        /// Retorna um trailler para o objeto <see cref="Arquivo"/>
        /// </summary>
        public static string GetTrailler => new ArquivoTrailler().ToString();
    }
}
