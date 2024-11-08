namespace _04.Middleware.Middlewares
{
    public class RequestEditingMiddleware
    {
        RequestDelegate _requestDelegate;

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        //Method ismi önemlidir. Invoke olmalıdır.
        //Request ve response'ye HttpContext üzerinden erişebiliyoruz.
        public async Task Invoke(HttpContext context)
        {
            //iak.com.tr/ismail => /ismail path'dir.
            if (context.Request.Path.ToString() == "/ismail")
                await context.Response.WriteAsync("Hos geldin ismail");
            else
                await _requestDelegate.Invoke(context);
                //Gelen isteği sunucuya ya da sonraki middleware'ye gönderen yapıdır.
        }
    }
}
