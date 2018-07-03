## AlterDataIn

[![NuGet Version](https://img.shields.io/nuget/v/Nuget.Core.svg)](https://www.nuget.org/packages/alterdatain)

AlterDataIn é um componente que visa facilitar a geração da estrutura do Arquivo de Importação de Dados para o ERP.
Ele implementa algumas restrições aplicando regras básicas de utilização validadas de acordo com a especificação original.

#### Por onde começar
Este componente também está disponível como um [NuGet Package](http://example.com)
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

## License

This software is open source, licensed under the Apache License, Version 2.0.
See [LICENSE.txt](https://github.com/pncq/alterdatain/blob/master/LICENSE.txt) for details.
Check out the terms of the license before you contribute, fork, copy or do anything
with the code. If you decide to contribute you agree to grant copyright of all your contribution to this project, and agree to
mention clearly if do not agree to these terms. Your work will be licensed with the project at Apache V2, along the rest of the code.
