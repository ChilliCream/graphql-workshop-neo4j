using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Neo4j.Driver;


IDriver driver = GraphDatabase.Driver(
    "neo4j://localhost:7687", 
    AuthTokens.Basic("neo4j", "test123"));

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton(driver)
    .AddGraphQLServer()
    .AddQueryType()
    .AddMovieLibraryTypes();

await using var app = builder.Build();

app.MapGraphQL();

await app.RunAsync();
