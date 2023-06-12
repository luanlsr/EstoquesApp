#region services
using EstoqueApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(map => map.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddSwaggerDoc();
builder.Services.AddCorsPolicy();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddMediatR();
builder.Services.AddAutoMapperProfiles();
builder.Services.AddJwtBearer(builder.Configuration);

#endregion
#region builder
var app = builder.Build();

app.UseSwaggerDoc();
app.UseCorsPolicy();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


app.Run();
public partial class Program { }
#endregion