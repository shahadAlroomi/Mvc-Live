// Mvc : 3)model 2)view 1)controller 

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();


app.MapDefaultControllerRoute();












app.Run();

