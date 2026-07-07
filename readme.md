# YFMAdvisor

YFMAdvisor é uma engine open-source para o jogo Yu-Gi-Oh! Forbidden Memories.

O objetivo do projeto é representar toda a lógica do jogo de forma independente da interface gráfica.

O projeto é dividido em cinco pilares:

- Knowledge Base
- Fusion Engine
- Decision Engine
- Vision Engine
- Emulator Integration

O banco de dados é gerado automaticamente a partir da base de conhecimento.

## Tecnologias

- .NET Framework 4.8
- C#
- SQLite
- OpenCV (futuro)
- xUnit/NUnit (definição posterior)

## Estrutura

/src

- YFM.Core
- YFM.Data
- YFM.Engine
- YFM.Importers
- YFM.Research
- YFM.Tools
- YFM.UI

/docs

/knowledge

/database

/assets

/tests
