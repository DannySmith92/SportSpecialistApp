using WebApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
ConfigureService.ConfigureServices(builder.Services, builder.Configuration);
var app = builder.Build();
ConfigureService.Configure(app);

app.Run();