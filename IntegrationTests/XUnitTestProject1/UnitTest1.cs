using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using WebApplication1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
	    private readonly HttpClient _client;
	    public UnitTest1()
	    {
		    var builder = new WebHostBuilder().UseStartup<Startup>();
		    var testServer = new TestServer(builder);
		    _client = testServer.CreateClient();
	    }
        [Fact]
        public async Task Test1()
        {
	        var result = await _client.GetAsync("Values/Add?a=1&b=2");
	        result.EnsureSuccessStatusCode();

	        var data = await result.Content.ReadAsStringAsync();
			Assert.Equal("3", data);
        }
    }
}
