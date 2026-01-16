using TicTacToeGame.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddScoped<IGameService, GameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Game}/{action=Index}/{id?}");

app.Run();
