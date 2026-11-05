using JenkinsBlazor.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();
builder.Services.AddControllers();

var app = builder.Build();

app.UseAntiforgery();
app.MapControllers();
app.MapRazorComponents<App>();

app.Run();
