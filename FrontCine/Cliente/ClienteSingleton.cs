using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesCine.Cliente
{
     class ClienteSingleton
    {
        private static ClienteSingleton Instance;
        private HttpClient client;

        private ClienteSingleton()
        {
            client = new HttpClient();
        }
        public static ClienteSingleton getinstancia()
        {
            if(Instance == null)
                Instance = new ClienteSingleton();
            return Instance;
        }

        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
    }


}
