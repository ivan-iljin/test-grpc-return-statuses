using error.tests.grpc;
using Grpc.Core;

Console.WriteLine("Hello, World!");

var service = new TestGrpcStatuses.TestGrpcStatusesServiceImpl();

var hostname = "localhost";
var port = 8888;

var server = new Server()
{
    Services = { TestGrpcStatusService.BindService(service) },
    Ports = {
        new ServerPort(
            hostname,
            port,
            ServerCredentials.Insecure
        )
    },
};

server.Start();
Console.WriteLine($"Server is listening from {hostname} on port {port}");

Console.WriteLine("Press enter to stop the server...");
Console.Read();

await server.KillAsync();
return 0;