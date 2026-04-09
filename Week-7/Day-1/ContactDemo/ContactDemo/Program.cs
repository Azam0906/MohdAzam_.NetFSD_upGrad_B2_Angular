using ContactDemo.DataAccess;
using ContactDemo.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

builder.Services.AddScoped<IContactRepo<ContactInfo>, ContactRepoImp>();
builder.Services.AddControllersWithViews();


var app = builder.Build();
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
}); app.Run();
