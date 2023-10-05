// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using RevolvingGamesServer;

Console.WriteLine("Client running");

using var channel = GrpcChannel.ForAddress("https://localhost:7118");
var client = new RevolvingService.RevolvingServiceClient(channel);
var res = await client.CheckPrimeNmberAsync(new PrimeNumber()
{
    Id = 2,
    Number = 1,
    Timestamp = 1
});
Console.WriteLine(res.ToString());
