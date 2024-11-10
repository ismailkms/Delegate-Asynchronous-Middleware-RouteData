
using Microsoft.AspNetCore.Mvc;

namespace _05.RouteData.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var routeData = RouteData.Values;
            //Route'yi olduðu gibi alabilmemizi saðlar. Dictionary olarak getirir yani key,value tarzýnda gelir. Program.cs içerisinde yazdýðýmýz Route'ye göre key ve value'ler oluþur. Controller, Action ve id bir keydir. Burada Controller key'ine karþýlýk Home bir valuedir.

            //Özet geçersek bir Route'nin Controller,Action ve route olarak gönderilen bilgisinin(id vb.) elde edilmesini saðlar.

            string? controller = routeData["controller"]?.ToString();
            string? controller2 = RouteData.Values["controller"]?.ToString();

            string? action = routeData["action"]?.ToString();
            string? action2 = RouteData.Values["action"]?.ToString();

            int id, id2 = 0;
            if (routeData["id"] is not null)
            {
                id = int.Parse(routeData["id"].ToString());
                id2 = int.Parse(RouteData.Values["id"].ToString());
            }
                
            return View();
        }

    }
}
