
using CandidateContactInfo.Data;
using CandidateContactInfo.Models;
using CandidateContactInfo.Repositories;
using CandidateContactInfo.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var candidateInfoConnection = builder.Configuration.GetConnectionString("CandidateInfoConnection");
if (string.IsNullOrEmpty(candidateInfoConnection))
{
    Console.WriteLine("candidateInfoConnection connection string is null or empty.");
}

// Add DbContext

builder.Services.AddDbContext<CandidateContext>(options =>
    options.UseSqlServer(candidateInfoConnection));



    // Add Repositories and Services
builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();

builder.Services.AddScoped<ICandidateService, CandidateService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();
app.UseRouting();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
