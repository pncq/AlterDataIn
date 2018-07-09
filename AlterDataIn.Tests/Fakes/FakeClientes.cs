using System;
using AlterDataIn.Domain;
using System.Collections.Generic;
using AlterDataIn.Domain.Clientes;

namespace AlterDataIn.Tests.Fakes
{
    using static DateTime;
    using static AlterdataBase;

    public class FakeClientes
    {
        public static IEnumerable<ClientesDadosPrincipais> RetornaClientesDadosPrincipais
        {
            get
            {
                yield return new ClientesDadosPrincipais
                {
                    CodigoChamada = "00100",
                    NomeCliente = "NOME DO CLIENTE",
                    TipoPessoa = "J",
                    NomeCurto = "NOME CURTO",
                    CnpjCpf = "99.999.999/9999-99"
                };

                yield return new ClientesDadosPrincipais
                {
                    CodigoChamada = "00200",
                    NomeCliente = "OUTRO NOME CLIENTE",
                    TipoPessoa = "J",
                    NomeCurto = "OUTRO NOME CURTO",
                    CnpjCpf = "88.888.888/8888-88"
                };

                yield return new ClientesDadosPrincipais
                {
                    CodigoChamada = "00300",
                    NomeCliente = "MAIS UM NOME CLIENTE",
                    TipoPessoa = "F",
                    NomeCurto = "MAIS UM NOME CURTO",
                    CnpjCpf = "777.777.777-77"
                };
            }
        }

        public static IEnumerable<ClientesEnderecos> RetornaClientesEnderecos
        {
            get
            {
                yield return new ClientesEnderecos
                {
                    CodigoChamada = "00100",
                    NomeCliente = "NOME DO CLIENTE",
                    NascimentoInicioAtividade = Today.ToString("ddMMyyyy"),
                    CnpjCpf = "99.999.999/9999-99",
                    InscricaoEstadual = "0123456-7",
                    InscricaoMunicipal = "01.00001-1",
                    Suframa = "01-0/1    001.01",
                    Logradouro = "OTÁVIO VILELLA",
                    NumeroLogradouro = "201",
                    Complemento = "NÃO TEM",
                    Bairro = "COPACABANA",
                    Cidade = "RIO DE JANEIRO",
                    Uf = "RJ",
                    Cep = "99999-999",
                    SequencialEndereco = "01",
                    EnderecoAtivo = "S",
                    TipoLogradouro = "RUA"
                };

                yield return new ClientesEnderecos
                {
                    CodigoChamada = "00200",
                    NomeCliente = "OUTRO NOME CLIENTE",
                    NascimentoInicioAtividade = Today.ToString("ddMMyyyy"),
                    CnpjCpf = "88.888.888/8888-88",
                    InscricaoEstadual = "7654321-0",
                    InscricaoMunicipal = "02.00002-2",
                    Suframa = "02-0/2    002.02",
                    Logradouro = "CORONEL CAMISAO",
                    NumeroLogradouro = "190",
                    Complemento = "ALI DO LADO",
                    Bairro = "MARACANÃ",
                    Cidade = "RIO DE JANEIRO",
                    Uf = "SP",
                    Cep = "88888-888",
                    SequencialEndereco = "01",
                    EnderecoAtivo = "S",
                    TipoLogradouro = "RUA"
                };

                yield return new ClientesEnderecos
                {
                    CodigoChamada = "00300",
                    NomeCliente = "MAIS UM NOME CLIENTE",
                    NascimentoInicioAtividade = Today.ToString("ddMMyyyy"),
                    CnpjCpf = "77.777.777/7777-77",
                    InscricaoEstadual = "7777777-7",
                    InscricaoMunicipal = "77.77777-7",
                    Suframa = "03-0/3    003.03",
                    Logradouro = "RUI BARBOSA",
                    NumeroLogradouro = "4490",
                    Complemento = "LOGO APÓS",
                    Bairro = "BARRA DA TIJUCA",
                    Cidade = "SÃO GONÇALO",
                    Uf = "RR",
                    Cep = "77777-777",
                    SequencialEndereco = "01",
                    EnderecoAtivo = "S",
                    TipoLogradouro = "ESTRADA"
                };
            }
        }

        public static IEnumerable<ClientesComplementoEndereco> RetornaClientesComplementoEndereco
        {
            get
            {
                yield return new ClientesComplementoEndereco
                {
                    CodigoChamada = "00100",
                    NomeCliente = "NOME DO CLIENTE",
                    Telefone = "(99) 9 9999-9999",
                    Fax = "(88) 8 8888-8888",
                    Celular = "(77) 7 7777-7777",
                    Email = "email@email.com.br",
                    PessoaContato = "Pedro Alvares Cabral",
                    StatusEnderecoPrincipal = "S",
                    StatusEnderecoEntrega = "N",
                    StatusEnderecoCobranca = "N",
                    StatusEnderecoCorrespondencia = "N",
                    StatusEnderecoComercial = "N",
                    StatusEnderecoResidencial = "N",
                    Observacao = "REALIZANDO TESTE UNITÁRIO",
                    SequencialEndereco = "01",
                    CnpjCpf = "99.999.999/9999-99"
                };

                yield return new ClientesComplementoEndereco
                {
                    CodigoChamada = "00200",
                    NomeCliente = "OUTRO NOME CLIENTE",
                    Telefone = "(66) 6 6666-6666",
                    Fax = "(55) 5 5555-5555",
                    Celular = "(44) 4 4444-4444",
                    Email = "email@email.com.br",
                    PessoaContato = "Tiradentes",
                    StatusEnderecoPrincipal = "S",
                    StatusEnderecoEntrega = "N",
                    StatusEnderecoCobranca = "N",
                    StatusEnderecoCorrespondencia = "N",
                    StatusEnderecoComercial = "N",
                    StatusEnderecoResidencial = "N",
                    Observacao = "REALIZANDO TESTE UNITÁRIO 2",
                    SequencialEndereco = "01",
                    CnpjCpf = "88.888.888/8888-88"
                };

                yield return new ClientesComplementoEndereco
                {
                    CodigoChamada = "00300",
                    NomeCliente = "MAIS UM NOME CLIENTE",
                    Telefone = "(33) 3 3333-3333",
                    Fax = "(22) 2 2222-2222",
                    Celular = "(11) 1 1111-1111",
                    Email = "pncq3@pncq.org.br",
                    PessoaContato = "Sócrates",
                    StatusEnderecoPrincipal = "S",
                    StatusEnderecoEntrega = "N",
                    StatusEnderecoCobranca = "N",
                    StatusEnderecoCorrespondencia = "N",
                    StatusEnderecoComercial = "N",
                    StatusEnderecoResidencial = "N",
                    Observacao = "REALIZANDO TESTE UNITÁRIO 3",
                    SequencialEndereco = "01",
                    CnpjCpf = "777.777.777-77"
                };
            }
        }

        public static IEnumerable<ClientesDadosComplementares> RetornaClientesDadosComplementares
        {
            get
            {
                yield return new ClientesDadosComplementares
                {
                    CodigoChamada = "00100",
                    Sexo = "MASCULINO",
                    DataNascimento = Today.ToString("ddMMyyyy"),
                    Identidade = "123456",
                    OrgaoExpedidor = "DETRAN/RJ",
                    Nacionalidade = "BRASILEIRO",
                    UfNaturalidade = "RJ",
                    Profissao = "CONSULTOR",
                    EstadoCivil = "C",
                    NomePai = "NOME PAI",
                    NomeMae = "NOME MAE",
                    NumeroCtps = "NUMERO CTPS",
                    RamoAtividade = "RAMO ATIVIDADE",
                    InicioAtividade = Today.ToString("ddMMyyyy"),
                    RegistroJustaComercial = "REGISTRO JUNTA COMERCIAL",
                    RegistroCivil = "REGISTRO CIVIL",
                    CapitalRegistrado = FormatarMoeda(1.5m),
                    CapitalAtual = FormatarMoeda(1.5m),
                    CapitalGiro = FormatarMoeda(1.5m),
                    ValorEstoque = FormatarMoeda(1.5m),
                    FaturamentoAnual = FormatarMoeda(1.5m),
                    NumeroFuncionarios = "002000",
                    CadastradoEm = Today.ToString("ddMMyyyy"),
                    ValorLimiteCredito = FormatarMoeda(1.5m),
                    Observacao = "OBSERVAÇÃO",
                    CodigoChamadaTransportador = "654321",
                    CnpjCpf = "99.999.999/9999-99"
                };

                yield return new ClientesDadosComplementares
                {
                    CodigoChamada = "00200",
                    Sexo = "MASCULINO",
                    DataNascimento = Today.ToString("ddMMyyyy"),
                    Identidade = "123456",
                    OrgaoExpedidor = "DETRAN/RJ",
                    Nacionalidade = "BRASILEIRO",
                    UfNaturalidade = "SP",
                    Profissao = "PROGRAMADOR",
                    EstadoCivil = "C",
                    NomePai = "NOME PAI",
                    NomeMae = "NOME MAE",
                    NumeroCtps = "NUMERO CTPS",
                    RamoAtividade = "RAMO ATIVIDADE",
                    InicioAtividade = Today.ToString("ddMMyyyy"),
                    RegistroJustaComercial = "REGISTRO JUNTA COMERCIAL",
                    RegistroCivil = "REGISTRO CIVIL",
                    CapitalRegistrado = FormatarMoeda(1.3m),
                    CapitalAtual = FormatarMoeda(1.3m),
                    CapitalGiro = FormatarMoeda(1.3m),
                    ValorEstoque = FormatarMoeda(1.3m),
                    FaturamentoAnual = FormatarMoeda(1.3m),
                    NumeroFuncionarios = "000500",
                    CadastradoEm = Today.ToString("ddMMyyyy"),
                    ValorLimiteCredito = FormatarMoeda(1.3m),
                    Observacao = "OBSERVAÇÃO AQUI",
                    CodigoChamadaTransportador = "654321",
                    CnpjCpf = "88.888.888/8888-88"
                };

                yield return new ClientesDadosComplementares
                {
                    CodigoChamada = "00300",
                    Sexo = "MASCULINO",
                    DataNascimento = Today.ToString("ddMMyyyy"),
                    Identidade = "753214",
                    OrgaoExpedidor = "DETRAN/RJ",
                    Nacionalidade = "BRASILEIRO",
                    UfNaturalidade = "ES",
                    Profissao = "PRODUCT MANAGER",
                    EstadoCivil = "S",
                    NomePai = "NOME PAI",
                    NomeMae = "NOME MAE",
                    NumeroCtps = "NUMERO CTPS",
                    RamoAtividade = "RAMO ATIVIDADE",
                    InicioAtividade = Today.ToString("ddMMyyyy"),
                    RegistroJustaComercial = "REGISTRO JUNTA COMERCIAL",
                    RegistroCivil = "REGISTRO CIVIL",
                    CapitalRegistrado = FormatarMoeda(0.5m),
                    CapitalAtual = FormatarMoeda(0.5m),
                    CapitalGiro = FormatarMoeda(0.5m),
                    ValorEstoque = FormatarMoeda(0.15m),
                    FaturamentoAnual = FormatarMoeda(10.5m),
                    NumeroFuncionarios = "080000",
                    CadastradoEm = Today.ToString("ddMMyyyy"),
                    ValorLimiteCredito = FormatarMoeda(1.5m),
                    Observacao = "OBSERVAÇÃO NESSE CAMPO",
                    CodigoChamadaTransportador = "654322",
                    CnpjCpf = "777.777.777-77"
                };
            }
        }

        public static IEnumerable<ClientesCaracteristicas> RetornaClientesCaracteristicas
        {
            get
            {
                yield return new ClientesCaracteristicas
                {
                    CodigoChamada = "00100",
                    CodigoCaracteristica = "123456",
                    DescricaoCaracteristica = "Descrição da Característica",
                    CnpjCpf = "99.999.999/9999-99"
                };

                yield return new ClientesCaracteristicas
                {
                    CodigoChamada = "00200",
                    CodigoCaracteristica = "654321",
                    DescricaoCaracteristica = "podendo conter até",
                    CnpjCpf = "88.888.888/8888-88"
                };

                yield return new ClientesCaracteristicas
                {
                    CodigoChamada = "00300",
                    CodigoCaracteristica = "112233",
                    DescricaoCaracteristica = "20 caracteres",
                    CnpjCpf = "777.777.777-77"
                };
            }
        }

        public static IEnumerable<ClientesPessoaRelacionada> RetornaClientesPessoaRelacionada
        {
            get
            {
                yield return new ClientesPessoaRelacionada
                {
                    CodigoChamada = "00100",
                    CodigoChamadaPessoaRelacionada = "123456",
                    TipoPessoaRelacionada = "F",
                    StatusPessoaRelacionadaPrincipal = "S",
                    CnpjCpf = "99.999.999/9999-99"
                };

                yield return new ClientesPessoaRelacionada
                {
                    CodigoChamada = "00200",
                    CodigoChamadaPessoaRelacionada = "654321",
                    TipoPessoaRelacionada = "T",
                    StatusPessoaRelacionadaPrincipal = "N",
                    CnpjCpf = "88.888.888/8888-88"
                };

                yield return new ClientesPessoaRelacionada
                {
                    CodigoChamada = "00200",
                    CodigoChamadaPessoaRelacionada = "112233",
                    TipoPessoaRelacionada = "C",
                    StatusPessoaRelacionadaPrincipal = "N",
                    CnpjCpf = "777.777.777-77"
                };
            }
        }

    }
}
