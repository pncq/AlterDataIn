using Xunit;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlterDataIn.Tests.Fakes;
using AlterDataIn.Domain.Arquivo;
using AlterDataIn.Domain.Clientes;

namespace AlterDataIn.Tests.Layouts
{
    using static FakeClientes;

    public class LayoutClientes
    {
        [Fact]
        public async Task Clientes_Teste()
        {
            var filename = $"{nameof(Clientes_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Clientes.GetHeader);
            conteudo.Append(Clientes.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"001000CLIENTES
001999{0}", DateTime.Today.ToString("ddMMyyyy"));

            Assert.Equal(expected, actual);
            Assert.True(Directory.Exists(Helper.PASTA_IMPORTACAO));

            var file = Path.Combine(Helper.PASTA_IMPORTACAO, filename);

            using (var sw = new StreamWriter(file))
            {
                await sw.WriteAsync(actual);
            }

            Assert.True(File.Exists(file));
        }

        [Fact]
        public async Task Clientes_Dados_Principais()
        {
            var filename = $"{nameof(Clientes_Dados_Principais)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            conteudo.Append(RetornaClientesDadosPrincipais.First()).AppendLine();

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001001000100NOME DO CLIENTE                                   JNOME CURTO          99999999999999    
001999{0}
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

        [Fact]
        public async Task Clientes_Enderecos_Teste()
        {
            var filename = $"{nameof(Clientes_Enderecos_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            conteudo.Append(RetornaClientesEnderecos.First()).AppendLine();

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001002000100NOME DO CLIENTE                                   {0}99999999999999    01234567          01000011            010100101           OTÁVIO VILELLA                                    201       NÃO TEM                                           COPACABANA                                        RIO DE JANEIRO                                    RJ99999999 01SRUA  
001999{0}
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

        [Fact]
        public async Task Clientes_Complemento_Endereco_Teste()
        {
            var filename = $"{nameof(Clientes_Complemento_Endereco_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            conteudo.Append(RetornaClientesComplementoEndereco.First()).AppendLine();

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001003000100NOME DO CLIENTE                                   (99) 9 9999-9999                                  (88) 8 8888-8888                                  (77) 7 7777-7777                                  email@email.com.br                                Pedro Alvares Cabral                              SNNNNNREALIZANDO TESTE UNITÁRIO                                                                           0199999999999999    
001999{0}
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

        [Fact]
        public async Task Clientes_Dados_Complementares_Teste()
        {
            var filename = $"{nameof(Clientes_Dados_Complementares_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            conteudo.Append(RetornaClientesDadosComplementares.First()).AppendLine();

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001004000100M{0}123456              DETRAN/RJ           BRASILEIRO          RJCONSULTOR           CNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000150000000000001500000000000015000000000000150000000000001500002000{0}00000000015000OBSERVAÇÃO                                                                                                                                                                                              65432199999999999999    
001999{0}
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

        [Fact]
        public async Task Clientes_Todos_Dados_Teste()
        {
            var filename = $"{nameof(Clientes_Todos_Dados_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            conteudo.Append(RetornaClientesDadosPrincipais.First()).AppendLine();
            conteudo.Append(RetornaClientesEnderecos.First()).AppendLine();
            conteudo.Append(RetornaClientesComplementoEndereco.First()).AppendLine();
            conteudo.Append(RetornaClientesDadosComplementares.First()).AppendLine();

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001001000100NOME DO CLIENTE                                   JNOME CURTO          99999999999999    
001002000100NOME DO CLIENTE                                   {0}99999999999999    01234567          01000011            010100101           OTÁVIO VILELLA                                    201       NÃO TEM                                           COPACABANA                                        RIO DE JANEIRO                                    RJ99999999 01SRUA  
001003000100NOME DO CLIENTE                                   (99) 9 9999-9999                                  (88) 8 8888-8888                                  (77) 7 7777-7777                                  email@email.com.br                                Pedro Alvares Cabral                              SNNNNNREALIZANDO TESTE UNITÁRIO                                                                           0199999999999999    
001004000100M{0}123456              DETRAN/RJ           BRASILEIRO          RJCONSULTOR           CNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000150000000000001500000000000015000000000000150000000000001500002000{0}00000000015000OBSERVAÇÃO                                                                                                                                                                                              65432199999999999999    
001999{0}
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

        [Fact]
        public async Task Tres_Clientes_Todos_Dados_Teste()
        {
            var filename = $"{nameof(Tres_Clientes_Todos_Dados_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            RetornaClientesDadosPrincipais.ToList()
                .ForEach(c => conteudo.Append(c).AppendLine());

            RetornaClientesEnderecos.ToList()
                .ForEach(c => conteudo.Append(c).AppendLine());

            RetornaClientesComplementoEndereco.ToList()
                .ForEach(c => conteudo.Append(c).AppendLine());

            RetornaClientesDadosComplementares.ToList()
                .ForEach(c => conteudo.Append(c).AppendLine());

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001001000100NOME DO CLIENTE                                   JNOME CURTO          99999999999999    
001001000200OUTRO NOME CLIENTE                                JOUTRO NOME CURTO    88888888888888    
001001000300MAIS UM NOME CLIENTE                              FMAIS UM NOME CURTO  77777777777       
001002000100NOME DO CLIENTE                                   {0}99999999999999    01234567          01000011            010100101           OTÁVIO VILELLA                                    201       NÃO TEM                                           COPACABANA                                        RIO DE JANEIRO                                    RJ99999999 01SRUA  
001002000200OUTRO NOME CLIENTE                                {0}88888888888888    76543210          02000022            020200202           CORONEL CAMISAO                                   190       ALI DO LADO                                       MARACANÃ                                          RIO DE JANEIRO                                    SP88888888 01SRUA  
001002000300MAIS UM NOME CLIENTE                              {0}77777777777777    77777777          77777777            030300303           RUI BARBOSA                                       4490      LOGO APÓS                                         BARRA DA TIJUCA                                   SÃO GONÇALO                                       RR77777777 01SESTRA
001003000100NOME DO CLIENTE                                   (99) 9 9999-9999                                  (88) 8 8888-8888                                  (77) 7 7777-7777                                  email@email.com.br                                Pedro Alvares Cabral                              SNNNNNREALIZANDO TESTE UNITÁRIO                                                                           0199999999999999    
001003000200OUTRO NOME CLIENTE                                (66) 6 6666-6666                                  (55) 5 5555-5555                                  (44) 4 4444-4444                                  email@email.com.br                                Tiradentes                                        SNNNNNREALIZANDO TESTE UNITÁRIO 2                                                                         0188888888888888    
001003000300MAIS UM NOME CLIENTE                              (33) 3 3333-3333                                  (22) 2 2222-2222                                  (11) 1 1111-1111                                  pncq3@pncq.org.br                                 Sócrates                                          SNNNNNREALIZANDO TESTE UNITÁRIO 3                                                                         0177777777777       
001004000100M{0}123456              DETRAN/RJ           BRASILEIRO          RJCONSULTOR           CNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000150000000000001500000000000015000000000000150000000000001500002000{0}00000000015000OBSERVAÇÃO                                                                                                                                                                                              65432199999999999999    
001004000200M{0}123456              DETRAN/RJ           BRASILEIRO          SPPROGRAMADOR         CNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000130000000000001300000000000013000000000000130000000000001300000500{0}00000000013000OBSERVAÇÃO AQUI                                                                                                                                                                                         65432188888888888888    
001004000300M{0}753214              DETRAN/RJ           BRASILEIRO          ESPRODUCT MANAGER     SNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000050000000000000500000000000005000000000000015000000000010500080000{0}00000000015000OBSERVAÇÃO NESSE CAMPO                                                                                                                                                                                  65432277777777777       
001999{0}
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

        [Fact]
        public async Task Tres_Clientes_Todos_Dados_Por_Cliente_Teste()
        {
            var filename = $"{nameof(Tres_Clientes_Todos_Dados_Por_Cliente_Teste)}.erp";
            var conteudo = new StringBuilder();

            conteudo.AppendLine(Arquivo.GetHeader);
            conteudo.AppendLine(Clientes.GetHeader);

            conteudo.Append(new Clientes
            {
                //ClientesHeader = new ClientesHeader(),
                ClientesDadosPrincipais = RetornaClientesDadosPrincipais.First(),
                ClientesEnderecos = RetornaClientesEnderecos.First(),
                ClientesComplementoEndereco = RetornaClientesComplementoEndereco.First(),
                ClientesDadosComplementares = RetornaClientesDadosComplementares.First(),
                //ClientesTrailler = new ClientesTrailler()
            });

            conteudo.Append(new Clientes
            {
                //ClientesHeader = new ClientesHeader(),
                ClientesDadosPrincipais = RetornaClientesDadosPrincipais.Skip(1).First(),
                ClientesEnderecos = RetornaClientesEnderecos.Skip(1).First(),
                ClientesComplementoEndereco = RetornaClientesComplementoEndereco.Skip(1).First(),
                ClientesDadosComplementares = RetornaClientesDadosComplementares.Skip(1).First(),
                //ClientesTrailler = new ClientesTrailler()
            });

            conteudo.Append(new Clientes
            {
                //ClientesHeader = new ClientesHeader(),
                ClientesDadosPrincipais = RetornaClientesDadosPrincipais.Last(),
                ClientesEnderecos = RetornaClientesEnderecos.Last(),
                ClientesComplementoEndereco = RetornaClientesComplementoEndereco.Last(),
                ClientesDadosComplementares = RetornaClientesDadosComplementares.Last(),
                //ClientesTrailler = new ClientesTrailler()
            });

            conteudo.AppendLine(Clientes.GetTrailler);
            conteudo.Append(Arquivo.GetTrailler);

            var actual = conteudo.ToString();
            var expected = string.Format(@"000000ALTERDATA
001000CLIENTES
001001000100NOME DO CLIENTE                                   JNOME CURTO          99999999999999    
001002000100NOME DO CLIENTE                                   {0}99999999999999    01234567          01000011            010100101           OTÁVIO VILELLA                                    201       NÃO TEM                                           COPACABANA                                        RIO DE JANEIRO                                    RJ99999999 01SRUA  
001003000100NOME DO CLIENTE                                   (99) 9 9999-9999                                  (88) 8 8888-8888                                  (77) 7 7777-7777                                  email@email.com.br                                Pedro Alvares Cabral                              SNNNNNREALIZANDO TESTE UNITÁRIO                                                                           0199999999999999    
001004000100M{0}123456              DETRAN/RJ           BRASILEIRO          RJCONSULTOR           CNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000150000000000001500000000000015000000000000150000000000001500002000{0}00000000015000OBSERVAÇÃO                                                                                                                                                                                              65432199999999999999    
001001000200OUTRO NOME CLIENTE                                JOUTRO NOME CURTO    88888888888888    
001002000200OUTRO NOME CLIENTE                                {0}88888888888888    76543210          02000022            020200202           CORONEL CAMISAO                                   190       ALI DO LADO                                       MARACANÃ                                          RIO DE JANEIRO                                    SP88888888 01SRUA  
001003000200OUTRO NOME CLIENTE                                (66) 6 6666-6666                                  (55) 5 5555-5555                                  (44) 4 4444-4444                                  email@email.com.br                                Tiradentes                                        SNNNNNREALIZANDO TESTE UNITÁRIO 2                                                                         0188888888888888    
001004000200M{0}123456              DETRAN/RJ           BRASILEIRO          SPPROGRAMADOR         CNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000130000000000001300000000000013000000000000130000000000001300000500{0}00000000013000OBSERVAÇÃO AQUI                                                                                                                                                                                         65432188888888888888    
001001000300MAIS UM NOME CLIENTE                              FMAIS UM NOME CURTO  77777777777       
001002000300MAIS UM NOME CLIENTE                              {0}77777777777777    77777777          77777777            030300303           RUI BARBOSA                                       4490      LOGO APÓS                                         BARRA DA TIJUCA                                   SÃO GONÇALO                                       RR77777777 01SESTRA
001003000300MAIS UM NOME CLIENTE                              (33) 3 3333-3333                                  (22) 2 2222-2222                                  (11) 1 1111-1111                                  pncq3@pncq.org.br                                 Sócrates                                          SNNNNNREALIZANDO TESTE UNITÁRIO 3                                                                         0177777777777       
001004000300M{0}753214              DETRAN/RJ           BRASILEIRO          ESPRODUCT MANAGER     SNOME PAI                                          NOME MAE                                          NUMERO CTPRAMO ATIVIDADE                                    {0}REGISTRO JUNTA COMERREGISTRO CIVIL      000000000050000000000000500000000000005000000000000015000000000010500080000{0}00000000015000OBSERVAÇÃO NESSE CAMPO                                                                                                                                                                                  65432277777777777       
001999{0}
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
