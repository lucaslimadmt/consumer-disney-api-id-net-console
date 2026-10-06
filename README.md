# Consumer Disney API

Aplicação de console em C# para consultar um personagem na API pública **Disney API**.

## Funcionamento

O programa realiza uma requisição HTTP para:

```text
https://api.disneyapi.dev/character/423
```

A resposta JSON é convertida para objetos C# e os dados obtidos são utilizados pela aplicação.

## Tecnologias

- C#
- .NET
- `HttpClient`
- Newtonsoft.Json
- API REST

## Arquivos principais

- `Program.cs` — fluxo principal e chamada à API.
- `Character.cs` — classes que representam a estrutura dos dados retornados.
- `ConsumerDisneyIdApi.csproj` — configuração do projeto e dependências.

## Como executar

Com o .NET SDK instalado:

```bash
dotnet restore
dotnet run
```

## Objetivo

Projeto acadêmico para praticar consumo de APIs REST e desserialização de JSON em C#.
