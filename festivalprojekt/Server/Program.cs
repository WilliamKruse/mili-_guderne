﻿using Microsoft.AspNetCore.ResponseCompression;
using festivalprojekt.Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//her
builder.Services.AddScoped<dBContext>();
builder.Services.AddScoped<IPersonRepositoryDapper, PersonRepositoryDapper>();
builder.Services.AddScoped<IVagtRepositoryDapper, VagtRepositoryDapper>();
builder.Services.AddScoped<IVagtTypeReposityDapper, VagtTypeRepositoryDapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

