using System;
using System.Threading.Tasks;
using AspNetCoregRpcService;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;

namespace AspNetCoreGrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "晓晨" });
            Console.WriteLine("调用Greeter服务 : " + reply.Message);

            var catClient = new LuCat.LuCatClient(channel);
            var catReply = await catClient.SuckingCatAsync(new Empty());
            Console.WriteLine("调用撸猫服务："+ catReply.Message);
            Console.ReadKey();
        }
    }
}
