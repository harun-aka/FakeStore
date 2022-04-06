using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApiService
{
    internal class Endpoint
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string LoginEndpoint { get; set; }
        public string ProductsEndpoint { get; set; }
    }
}
