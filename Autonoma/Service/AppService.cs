using Autonoma.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Autonoma.Service
{
    public static class AppService
    {
        public static async Task<Root> GetClima(double latitud, double longitud)
        {
            var httpClient = new  HttpClient();
            var responce = await httpClient.GetStringAsync(string.Format("https://api.tutiempo.net/json/?lan=es&apid=zxEq44aqz44t3k9&ll={0},{1}", latitud, longitud));
            return JsonConvert.DeserializeObject<Root>(responce);
        }
    }
}
