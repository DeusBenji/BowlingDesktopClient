using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface IServiceConnection
    {

        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        public HttpClient HttpEnabler { get; init; }
        Task<HttpResponseMessage?> CallServiceGet();
        Task<HttpResponseMessage?> CallServicePost(StringContent postJson);
        Task<HttpResponseMessage?> CallServicePut(StringContent postJson);
        Task<HttpResponseMessage?> CallServiceDelete();
        Task<HttpResponseMessage?> CallServicePost(HttpRequestMessage postRequest);

    }
}
