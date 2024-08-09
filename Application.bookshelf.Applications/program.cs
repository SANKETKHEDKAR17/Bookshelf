using Application.bookshelf.Infractructure;
using Application.bookshelf.Repository;
using Application.bookshelf.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddTransient<BookShelfDbContext>();
        builder.Services.AddTransient<IBookRepo,BookRepo>();
        builder.Services.AddTransient<IBookService, BookService>();
        builder.Services.AddTransient<IUserRepo, UserRepo>();
        builder.Services.AddTransient<IUserService, UserService>();

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

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern :"api/({contriller}/{action})",
            defaults : "api/Book/GetAllBook"
            );

        app.Run();
    }
}