using Newtonsoft.Json;
using RabbitMQ.Client;
using RestService.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
List<GameOfThronesCharacter> gameOfThronesCharacters;
IModel kanal;

var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://game-of-thrones1.p.rapidapi.com/Characters"),
    Headers =
    {
        { "X-RapidAPI-Key", "e54a5c43fbmsh6558a281c8d635dp1fec2bjsn49b042ef2124" },
        { "X-RapidAPI-Host", "game-of-thrones1.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    gameOfThronesCharacters = JsonConvert.DeserializeObject<List<GameOfThronesCharacter>>(body);
}

ConnectionFactory RabbitMqServer = new ConnectionFactory();
IConnection poveznicaNaServer = RabbitMqServer.CreateConnection();
kanal = poveznicaNaServer.CreateModel();
kanal.QueueDeclare(queue: "GOT_CHARACTERS", exclusive: false);

builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();

builder.Services.AddSingleton<List<GameOfThronesCharacter>>(gameOfThronesCharacters);

builder.Services.AddSingleton<IModel>(kanal);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
