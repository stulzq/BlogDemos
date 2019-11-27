using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Health.V1;

namespace AspNetCoregRpcService
{
    public class HealthCheckService:Health.HealthBase
    {
        public override Task<HealthCheckResponse> Check(HealthCheckRequest request, ServerCallContext context)
        {
            //TODO:检查逻辑
            return Task.FromResult(new HealthCheckResponse(){Status = HealthCheckResponse.Types.ServingStatus.Serving});
        }

        public override async Task Watch(HealthCheckRequest request, IServerStreamWriter<HealthCheckResponse> responseStream, ServerCallContext context)
        {
            //TODO:检查逻辑
            await responseStream.WriteAsync(new HealthCheckResponse()
                {Status = HealthCheckResponse.Types.ServingStatus.Serving});
        }
    }
}