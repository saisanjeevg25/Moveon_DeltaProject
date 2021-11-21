using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoveOn_Relocation_Company_Mvc.Helper
{
    public class RequestApi
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:60426");
            return Client;
        }
    }
}
