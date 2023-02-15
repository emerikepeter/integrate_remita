using Microsoft.Extensions.Configuration;
using RemitaMiddleWare.Services;

namespace RemittaApi.Helpers
{
    public class Constance
    {
        public static string MERCHANTID { get; set; }
        public static string APIKEY { get; set; }
        public static string APITOKEN { get; set; }
        public static string IV { get; set; }
        public static string ENCKEY { get; set; }
    }
}