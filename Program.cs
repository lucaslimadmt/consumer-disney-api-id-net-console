//Coloco os comentarios para facilitar o entendimento e para o meu treino do codigo

using System.Net.Http;
using Newtonsoft.Json;

// Cria o cliente HTTP
HttpClient client = new HttpClient();

// Define o enderco da API
string url = "https://api.disneyapi.dev/character/423";

// Faz a requisicao e guarda a resposta
string json = await client.GetStringAsync(url);

// Transforma o texto JSON em objetos do C#
DisneyApiResponse? response = JsonConvert.DeserializeObject<DisneyApiResponse>(json);

// Exibe os dados no console
Console.WriteLine("Nome:");
Console.WriteLine(response?.data?.name);
Console.WriteLine("Imagem:");
Console.WriteLine(response?.data?.imageUrl);
