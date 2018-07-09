## AlterDataIn

[![NuGet Version](https://img.shields.io/nuget/v/alterdatain.svg)](https://www.nuget.org/packages/alterdatain)

AlterDataIn é um componente que visa facilitar a geração da estrutura do Arquivo de Importação de Dados para o ERP.
Ele implementa algumas restrições aplicando regras básicas de utilização validadas de acordo com a especificação original.

#### Por onde começar
Este componente também está disponível como um [NuGet Package](https://www.nuget.org/packages/alterdatain)
```
Install-Package AlterDataIn
```

## Especificação

#### Arquivo - Header
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "000000" |
| 0002 | Identificador Alterdata | 7 | 15 | 9 | 0 | C | Fixo "ALTERDATA" |

#### Clientes - Header
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001000" |
| 0002 | Identificador Clientes | 7 | 14 | 8 | 0 | C | Fixo "CLIENTES" |

#### Clientes - Detail 1 - Dados Principais
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001001" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Nome do Cliente | 13 | 62 | 50 | 0 | C | |
| 0004 | Tipo de Pessoa | 63 | 63 | 1 | 0 | C | \<F>ísica ou \<J>urídica |
| 0005 | Nome Curto | 64 | 83 | 20 | 0 | C | |
| 0006 | CNPJ/CPF | 84 | 101 | 18| 0 | C | |

#### Clientes - Detail 2 - Endereços
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001002" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Nome do Cliente | 13 | 62 | 50 | 0 | C | |
| 0004 | Data de Nascimento / Inicio de Atividade | 63 | 70 | 8 | 0 | D | |
| 0005 | CNPJ/CPF | 71 | 88 | 18 | 0 | C | |
| 0006 | Inscrição Estadual | 89 | 106 | 18 | 0 | C | |
| 0007 | Inscrição Municipal | 107 | 126 | 20 | 0 | C | |
| 0008 | SUFRAMA | 127 | 146 | 20 | 0 | C | |
| 0009 | Logradouro | 147 | 196 | 50 | 0 | C | |
| 0010 | Número Logradouro | 197 | 206 | 10 | 0 | C | |
| 0011 | Complemento | 207 | 256 | 50 | 0 | C | |
| 0012 | Bairro | 257 | 306 | 50 | 0 | C | |
| 0013 | Cidade | 307 | 356 | 50 | 0 | C | |
| 0014 | UF | 357 | 358 | 2 | 0 | C | |
| 0015 | CEP | 359 | 367 | 9 | 0 | C | |
| 0016 | Sequencial do Endereço | 368 | 369 | 2 | 0 | N | Numeração que faz vínculo entre os dados referente ao endereço |
| 0017 | Endereço Ativo | 370 | 370 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0018 | Tipo Logradouro | 371 | 375 | 5 | 0 | C | Rua, Av., Trav., etc. |

#### Clientes - Detail 3 - Complemento do Endereço
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001003" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Nome do Cliente | 13 | 62 | 50 | 0 | C | |
| 0004 | Telefone | 63 | 112 | 50 | 0 | C | |
| 0005 | Fax | 113 | 162 | 50 | 0 | C | |
| 0006 | Celular | 163 | 212 | 50 | 0 | C | |
| 0007 | E-Mail | 213 | 262 | 50 | 0 | C | |
| 0008 | Pessoa de Contato | 263 | 312 | 50 | 0 | C | |
| 0009 | Status de Endereço Principal | 313 | 313 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0010 | Status de Endereço Entrega | 314 | 314 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0011 | Status de Endereço Cobrança | 315 | 315 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0012 | Status de Endereço Correspondência | 316 | 316 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0013 | Status de Endereço Comercial | 317 | 317 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0014 | Status de Endereço Residencial | 318 | 318 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0015 | Observação | 319 | 418 | 100 | 0 | C | |
| 0016 | Sequencial do Endereço | 419 | 420 | 2 | 0 | N | Númeração que faz vínculo entre os dados referente ao endereço |
| 0017 | CNPJ/CPF | 421 | 438 | 18 | 0 | C | |

#### Clientes - Detail 4 - Dados Complementares
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001004" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Sexo | 13 | 13 | 1 | 0 | C | \<M>asculino ou \<F>eminino |
| 0004 | Data de Nascimento | 14 | 21 | 8 | 0 | D | |
| 0005 | Identidade | 22 | 41 | 20 | 0 | C | |
| 0006 | Órgão Expedidor | 42 | 61 | 20 | 0 | C | |
| 0007 | Nacionalidade | 62 | 81 | 20 | 0 | C | |
| 0008 | UF Naturalidade | 82 | 83 | 2 | 0 | C | |
| 0009 | Profissão | 84 | 103 | 20 | 0 | C | |
| 0010 | Estado Civil | 104 | 104 | 1 | 0 | C | \<S>olteiro, \<C>asado, \<D>ivorciado, \<V>iúvo, Separado\<J>udicialmente, \<A>maziado |
| 0011 | Nome do Pai | 105 | 154 | 50 | 0 | C | |
| 0012 | Nome da Mãe | 155 | 204 | 50 | 0 | C | |
| 0013 | Número CTPS | 205 | 214 | 10 | 0 | C | |
| 0014 | Ramo de Atividade | 215 | 264 | 50 | 0 | C | |
| 0015 | Início de Atividade | 265 | 272 | 8 | 0 | D | |
| 0016 | Registro Junta Comercial | 273 | 292 | 20 | 0 | C | |
| 0017 | Registro Civil | 293 | 312 | 20 | 0 | C | |
| 0018 | Capital Registrado | 313 | 326 | 14 | 4 | N | |
| 0019 | Capital Atual | 327 | 340 | 14 | 4 | N | |
| 0020 | Capital de Giro | 341 | 354 | 14 | 4 | N | |
| 0021 | Valor do Estoque | 355 | 368 | 14 | 4 | N | |
| 0022 | Faturamento Anual | 369 | 382 | 14 | 4 | N | |
| 0023 | Número de Funcionários | 383 | 387 | 5 | 0 | N | |
| 0024 | Cadastrado em | 388 | 395 | 8 | 0 | D | |
| 0025 | Valor do Limite de Crédito | 396 | 409 | 14 | 4 | N | |
| 0026 | Observação | 410 | 609 | 200 | 0 | C | |
| 0027 | Código de Chamada do Transportador | 610 | 615 | 6 | 0 | C | |
| 0028 | CNPJ/CPF | 616 | 633 | 18 | 0 | C | |

#### Clientes - Detail 5 - Características
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001005" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Código da Característica | 13 | 18 | 6 | 0 | N | |
| 0004 | Descrição da Característica | 19 | 38 | 20 | 0 | C | |
| 0005 | CNPJ/CPF | 39 | 56 | 18 | 0 | C | |

#### Clientes - Detail 6 - Pessoa Relacionada
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001006" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Código de Chamada da Pessoa Relacionada | 13 | 18 | 6 | 0 | N | |
| 0004 | Tipo de Pessoa Relacionada | 19 | 19 | 1 | 0 | C | \<C>liente, \<F>ornecedor, \<T>ransportador, \<R>epresentante, \<P>rospectado ou T\<E>rceiro |
| 0005 | Status de Pessoa Relacionada | 20 | 20 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0006 | CNPJ/CPF | 21 | 38 | 18 | 0 | C | |

#### Clientes - Trailler
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001999" |
| 0002 | Data de geração dos dados | 7 | 14 | 8 | 0 | D | |

#### Contas a Receber - Header
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "002000" |
| 0002 | Data de geração dos dados | 7 | 14 | 8 | 0 | C | Fixo "ARECEBER" |

#### Contas a Receber - Detail 1 - Dados Principais
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "002001" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Código de Chamada da Pessoa | 13 | 18 | 6 | 0 | N | Código de Chamada da Pessoa do título |
| 0004 | Número do Título | 19 | 38 | 20 | 0 | C | |
| 0005 | Nome do Título | 39 | 88 | 50 | 0 | C | |
| 0006 | Data de Emissão | 89 | 96 | 8 | 0 | D | |
| 0007 | Data de Vencimento | 97 | 104 | 8 | 0 | D | |
| 0008 | Data Disponível | 105 | 112 | 8 | 0 | D | |
| 0009 | Valor do Título | 113 | 126 | 14 | 4 | N | |
| 0010 | Código de Chamada Natureza de Lançamento | 127 | 132 | 6 | 0 | N | |
| 0011 | Código de Chamada Forma de Pagamento | 133 | 138 | 6 | 0 | N | |
| 0012 | Código FEBRABAN Banco | 139 | 141 | 3 | 0 | N | |
| 0013 | Código de Chamada da Agência do Banco | 142 | 147 | 6 | 0 | N | |
| 0014 | Código de Chamada Conta Bancária | 148 | 153 | 6 | 0 | N | |
| 0015 | Número do Título no Banco | 154 | 203 | 50 | 0 | C | |
| 0016 | Código de Chamada Tipo de Cobrança | 204 | 209 | 6 | 0 | N | |
| 0017 | Data da Baixa do Título | 210 | 217 | 8 | 0 | D | |
| 0018 | Valor da Baixa do Título | 218 | 231 | 14 | 4 | N | |
| 0019 | Tipo de Baixa | 232 | 232 | 1 | 0 | C | \<T>otal ou \<P>arcial |
| 0020 | Observações | 233 | 432 | 200 | 0 | C | |
| 0021 | Identificador do Título | 433 | 442 | 10 | 0 | C | Chave primária que faz vínculo entre o título e os itens |
| 0022 | Número da Agência Bancária | 443 | 452 | 10 | 0 | C | |
| 0023 | Número da Conta Bancária | 453 | 472 | 20 | 0 | C | |
| 0024 | Categoria da Pessoa do Título | 473 | 473 | 1 | 0 | C | \<C>liente, \<F>ornecedor, \<R>epresentante, \<T>ransportador, F\<U>ncionário, \<P>rospectado, T\<E>receiro |
| 0025 | Tipo de Pessoa | 474 | 474 | 1 | 0 | C | \<F>ísica ou \<J>urídica |
| 0026 | CPF/CNPJ da Pessoa | 475 | 492 | 18 | 0 | C | |
| 0027 | Código de Chamada da Sit.Administrativa | 493 | 498 | 6 | 0 | N | |
| 0028 | Data de Exclusão do Título | 499 | 506 | 8 | 0 | D | |
| 0029 | Número de documento da baixa do Título | 507 | 556 | 50 | 0 | C | |
| 0030 | Código de Chamada do Centro de Custo | 557 | 562 | 6 | 0 | N | |
| 0031 | Status de cancelamento de baixa | 563 | 563 | 1 | 0 | C | \<S>im ou \<N>ão |
| 0032 | Número de Itens do Título | 564 | 569 | 6 | 0 | N | |
| 0033 | Número do cheque | 570 | 589 | 20 | 0 | C | |
| 0034 | Status Identificador de Título Unico | 590 | 590 | 1 | 0 | C | Indica se o identificador informado no campo 0021 é único na base de origem (chave primária) |

#### Contas a Receber - Detail 2 - Itens do Título
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "002002" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Código de Chamada do Cliente | 13 | 18 | 6 | 0 | N | |
| 0004 | Número do Título | 19 | 38 | 20 | 0 | C | |
| 0005 | Data de Referência | 39 | 46 | 8 | 0 | D | |
| 0006 | Descrição do item | 47 | 96 | 50 | 0 | C | |
| 0007 | Valor do Item | 97 | 110 | 14 | 4 | N | |
| 0008 | Identificador do Título | 111 | 120 | 10 | 0 | C | Chave primária que faz vínculo entre o título e os itens |
| 0009 | Código de Chamada do Tipo de Movimento de Cobrança | 121 | 126 | 6 | 0 | N | |
| 0010 | Número do Item | 127 | 136 | 10 | 0 | N | |
| 0011 | Código de Chamada Natureza de Lançamento do IRRF | 137 | 142 | 6 | 0 | N | |
| 0012 | Código de Chamada do Evento do IRRF | 143 | 148 | 6 | 0 | N | |
| 0013 | Valor do IRRF | 149 | 162 | 14 | 4 | N | |
| 0014 | Código de Chamada Natureza de Lançamento do PIS | 163 | 168 | 6 | 0 | N | |
| 0015 | Código de Chamada do Evento do PIS | 169 | 174 | 6 | 0 | N | |
| 0016 | Valor do PIS | 175 | 188 | 14 | 4 | N | |
| 0017 | Código de Chamada Natureza de Lançamento do COFINS | 189 | 194 | 6 | 0 | N | |
| 0018 | Código de Chamada do Evento do COFINS | 195 | 200 | 6 | 0 | N | |
| 0019 | Valor do COFINS | 201 | 214 | 14 | 4 | N | |
| 0020 | Código de Chamada Natureza de Lançamento do CSLL | 215 | 220 | 6 | 0 | N | |
| 0021 | Código de Chamada do Evento do CSLL | 221 | 226 | 6 | 0 | N | |
| 0022 | Valor do CSLL | 227 | 240 | 14 | 4 | N | |
| 0023 | Código de Chamada Natureza de Lançamento do INSS | 241 | 246 | 6 | 0 | N | |
| 0024 | Código de Chamada do Evento do INSS | 247 | 252 | 6 | 0 | N | |
| 0025 | Valor do INSS | 253 | 266 | 14 | 4 | N | |
| 0026 | Código de Chamada Natureza de Lançamento do ISS | 267 | 272 | 6 | 0 | N | |
| 0027 | Código de Chamada do Evento do ISS | 273 | 278 | 6 | 0 | N | |
| 0028 | Valor do ISS | 279 | 292 | 14 | 4 | N | |
| 0029 | Código de Chamada Nat.Lanc. do PIS/COFINS/CSLL | 293 | 298 | 6 | 0 | N | |
| 0030 | Código de Chamada do Evento do PIS/COFINS/CSLL | 299 | 304 | 6 | 0 | N | |
| 0031 | Valor do PIS/COFINS/CSLL | 305 | 318 | 14 | 4 | N | |
| 0032 | Código de Chamada Natureza de Lançamento de Outros | 319 | 324 | 6 | 0 | N | |
| 0033 | Código de Chamada do Evento de Outros | 325 | 330 | 6 | 0 | N | |
| 0034 | Valor de Outros | 331 | 344 | 14 | 4 | N | |
| 0035 | Código de Chamada Natureza de Lançamento de Juros | 345 | 350 | 6 | 0 | N | |
| 0036 | Código de Chamada do Evento de Juros | 351 | 356 | 6 | 0 | N | |
| 0037 | Valor de Juros | 357 | 370 | 14 | 4 | N | |
| 0038 | Código de Chamada Natureza de Lançamento de Multa | 371 | 376 | 6 | 0 | N | |
| 0039 | Código de Chamada do Evento de Multa | 377 | 382 | 6 | 0 | N | |
| 0040 | Valor de Multa | 383 | 396 | 14 | 4 | N | |
| 0041 | Código de Chamada Nat. de Lançamento de Desconto | 397 | 402 | 6 | 0 | N | |
| 0042 | Código de Chamada do Evento de Desconto | 403 | 408 | 6 | 0 | N | |
| 0043 | Valor de Desconto | 409 | 422 | 14 | 4 | N | |

#### Contas a Receber - Detail 3 - Repasse
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "002003" |
| 0002 | Código de Chamada | 7 | 12 | 6 | 0 | N | |
| 0003 | Código de Chamada do Cliente | 13 | 18 | 6 | 0 | N | |
| 0004 | Número do Título | 19 | 38 | 20 | 0 | C | |
| 0005 | Código Reduzido da Pessoa de Repasse | 39 | 44 | 6 | 0 | N | |
| 0006 | Base de Cálculo de Repasse | 45 | 58 | 14 | 4 | N | |
| 0007 | Alíquota de Repasse | 59 | 65 | 7 | 4 | N | |
| 0008 | Categoria da Pessoa de Repasse | 66 | 66 | 1 | 0 | C | \<R>epresentante ou \<F>uncionário |
| 0009 | Identificador do Título | 67 | 76 | 10 | 0 | C | Chave primária que faz vínculo entre o título e os itens |
| 0010 | Número do Item | 77 | 86 | 10 | 0 | N | |

#### Contas a Receber - Trailler
| Núm.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observação |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "002999" |
| 0002 | Data da geração dos dados | 7 | 14 | 8 | 0 | D | |

## License

This software is open source, licensed under the Apache License, Version 2.0.
See [LICENSE](https://github.com/pncq/alterdatain/blob/master/LICENSE) for details.
Check out the terms of the license before you contribute, fork, copy or do anything
with the code. If you decide to contribute you agree to grant copyright of all your contribution to this project, and agree to
mention clearly if do not agree to these terms. Your work will be licensed with the project at Apache V2, along the rest of the code.
