using Microsoft.EntityFrameworkCore;
using RepeatedMeetings.Models;





var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddDbContext<RepeatedMeetingsDBContext>(options => options
    .UseSqlServer(builder
    .Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline. 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();







//var builder = WebApplication.CreateBuilder(args);

//builder.Services
//    .AddDbContext<RepeatedMeetingsDBContext>(options => options
//    .UseSqlServer(builder
//    .Configuration.GetConnectionString("DefaultConnection")));

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//// app.MapRazorPages();


////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Member}/{action=Index}/{id?}");


//app.Run();


