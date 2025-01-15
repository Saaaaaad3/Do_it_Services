using Doit.Core.Application.Interfaces.Repository;
using Doit.Core.Application.Interfaces.Repository.Boards;
using Doit.Core.Application.Interfaces.Service.Boards;
using Doit.Core.Application.Interfaces.Service.TaskLists;
using Doit.Infrastructure.Database;
using Doit.Infrastructure.Repositories.Boards;
using Doit.Infrastructure.Repositories.TaskLists;
using Doit.Infrastructure.Services.Boards;
using Doit.Infrastructure.Services.TaskLists;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddScoped<IBoardsService, BoardsService>();
builder.Services.AddScoped<IBoardsRepo, BoardsRepo>();
builder.Services.AddScoped<ITaskListService, TaskListService>();
builder.Services.AddScoped<ITaskListRepo, TaskListRepo>();

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

    app.UseCors(builder => builder
    .WithOrigins("http://localhost:4200") // Replace with your Angular app's URL
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
    //app.UseCors(builder => builder
    //.WithOrigins("*")
    //.AllowAnyMethod()
    //.AllowAnyHeader()
    //);
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
