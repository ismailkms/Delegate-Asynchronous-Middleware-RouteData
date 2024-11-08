namespace _04.Middleware.Middlewares
{
    public class ResponseEditingMiddleware
    {
        RequestDelegate _requestDelegate;

        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        //Method ismi önemlidir. Invoke olmalıdır.
        //Request ve response'ye HttpContext üzerinden erişebiliyoruz.
        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);
            //Gelen isteği sunucuya ya da sonraki middleware'ye gönderen yapıdır.

            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
                await context.Response.WriteAsync("Sayfa bulunamadi");
        }
    }
}
