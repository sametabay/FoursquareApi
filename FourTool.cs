using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApi
{
    public class FourTool
    {

        public const string clientID = "W5SVVWFXISFW0UL1SA2RZ14ONK05PKUZWCT3N4O0X5J54X2G";
        public const string clientSecret = "JV1BXFE1EZNMUCHJP0UCB0CVJ2GXIYBSX20S31PCOSZ3CZ4Z";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "4f04af1f2fb6e1c99f3db0bb";
        public int radius = 500;
        public string latitude = "41.0446062";
        public string longitude = "29.0063537";


        string queryUrl = string.Empty;
        public string jsonString = string.Empty;
        public FourTool()
        {
            queryUrl += apiUrl;
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + $"{DateTime.Now:yyyyMMdd}";
            //queryUrl += "&v=" + string.Format("{0:yyyMMdd}", DateTime.Now);
            queryUrl += $"&ll={latitude},{longitude}";
            //queryUrl += string.Format("&ll={0},{1}", latitude, longitude);
            queryUrl += "&radius=" + radius;
            //queryUrl += "&categoryId=" + categoryCode;

            GetVenues(queryUrl);
        }
        async void GetVenues(string queryUrl)
        {
            HttpClient client = new HttpClient();
            try
            {
                jsonString = await client.GetStringAsync(queryUrl);
            }
            catch { }
        }
        //public List<Four.Venue> Venues { get; set; }
        public List<Four.Venue> FirmalariGetir()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(jsonString);
            return sonuc.response.venues.ToList();
        }
    }
}
