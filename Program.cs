var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Registered to mstamenov @ 2023");

app.Run();