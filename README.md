## AlterDataIn

[![NuGet Version](https://img.shields.io/nuget/v/Nuget.Core.svg)](https://www.nuget.org/packages/alterdatain)

AlterDataIn � um componente que visa facilitar a gera��o da estrutura do Arquivo de Importa��o de Dados para o ERP.
Ele implementa algumas restri��es aplicando regras b�sicas de utiliza��o validadas de acordo com a especifica��o original.

#### Por onde come�ar
Este componente tamb�m est� dispon�vel como um [NuGet Package](http://example.com)
```
Install-Package AlterDataIn
```

## Especifica��o

#### Arquivo - Header
| N�m.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observa��o |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "000000" |
| 0002 | Identificador Alterdata | 7 | 15 | 9 | 0 | C | Fixo "ALTERDATA" |

#### Clientes - Header
| N�m.                | Campo  | Inicial | Final            | Tam.| Dec. | Tipo | Observa��o |
| ---                 | ---    | ---     | ---              | --- | ---  | ---  | --- |
| 0001 | Identificador | 1 | 6 | 6 | 0 | N | Fixo "001000" |
| 0002 | Identificador Clientes | 7 | 14 | 8 | 0 | C | Fixo "CLIENTES" |

## License

This software is open source, licensed under the Apache License, Version 2.0.
See [LICENSE.txt](https://github.com/pncq/alterdatain/blob/master/LICENSE.txt) for details.
Check out the terms of the license before you contribute, fork, copy or do anything
with the code. If you decide to contribute you agree to grant copyright of all your contribution to this project, and agree to
mention clearly if do not agree to these terms. Your work will be licensed with the project at Apache V2, along the rest of the code.
