var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// app.MapGet("/", () => "Привет от ИСП-233! Автор: <Надя Олеся>");



app.MapGet("/", () => "Добро пожаловать на сервер");

app.MapGet("/about", () => "Это мой первый ASP.NET Core сервер");

app.MapGet("/time", () => $"Время на сервере: {DateTime.Now}");

app.MapGet("/hello/{name}", (string name) => $"Привет,{name}");

app.MapGet("/sum/{a}/{b}", (int a, int b) => $"Сумма:{a}+{b}={a+b}");

app.Run();