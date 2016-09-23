using System.Threading;
using System.Threading.Tasks;
using Nancy;

namespace NotificationCloud.WebApis.Modules
{
    /// <summary>
    /// For test
    /// </summary>
    public class HelloModule : NancyModule
    {
        public HelloModule() : base("/hello")
        {
            Get["/", true] = GetHello;
            Get["/{name}", true] = GreetHello;
        }

        private async Task<dynamic> GetHello(dynamic _, CancellationToken token)
        {
            return await Task.FromResult("Hello World");
        }

        private async Task<dynamic> GreetHello(dynamic _, CancellationToken token)
        {
            return await Task.FromResult("Hello, " + _.name);
        }
    }
}
