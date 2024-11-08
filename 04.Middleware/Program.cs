using _04.Middleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseMiddleware<ResponseEditingMiddleware>();
app.UseMiddleware<RequestEditingMiddleware>(); //Oluþturmuþ olduðumuz middleware'yi bu þekilde çaðýrdýk.

app.Run();
