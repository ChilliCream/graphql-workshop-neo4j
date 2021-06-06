using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType()
    .AddMovieLibraryTypes();

await using var app = builder.Build();

app.MapGraphQL();

await app.RunAsync();
