# Consulta de Personagem Disney API

Aplicação de console desenvolvida em **C# com .NET** para praticar o consumo de uma API REST e o tratamento de dados retornados em JSON.

O programa consulta a **Disney API** utilizando o identificador de um personagem e apresenta no terminal algumas informações recebidas na resposta.

## Funcionamento

Durante a execução, a aplicação realiza uma requisição HTTP para o endpoint:

```text
https://api.disneyapi.dev/character/423
```

Os dados retornados pela API são recebidos em formato JSON, convertidos para objetos C# e utilizados pelo programa para exibir informações do personagem consultado.

## Tecnologias utilizadas

- C#
- .NET
- HttpClient
- Newtonsoft.Json
- API REST
- JSON

## Arquivos principais

- `Program.cs` — responsável pela requisição à API e pela exibição dos dados.
- `Character.cs` — contém as classes que representam a estrutura dos dados retornados.
- `ConsumerDisneyIdApi.csproj` — arquivo de configuração do projeto e de suas dependências.

## Como executar

Com o **.NET SDK** compatível instalado, abra um terminal na pasta do projeto e execute:

```bash
dotnet restore
dotnet run
```

Após a execução, o programa realiza a consulta à API e mostra os dados obtidos diretamente no console.

## API utilizada

Este projeto utiliza a API pública **Disney API**:

```text
https://disneyapi.dev/
```
