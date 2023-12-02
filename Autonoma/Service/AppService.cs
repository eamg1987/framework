using Autonoma.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonoma.Service
{
    internal class AppService
    {
        public async void GetClima(double latitud, double longitud)
        {
            var httpClient = new httpClient();
            var responce = await httpClient.GetStringAsync("https://api.tutiempo.net/json/?lan=es&apid=zxEq44aqz44t3k9&ll=40.4178,-3.7022")
            return JsonConvert.DeserializeObject<Root>(responce);
        }
    }
}
