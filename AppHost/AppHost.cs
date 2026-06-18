using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithDataVolume()
    .WithPgAdmin()
    .WithLifetime(ContainerLifetime.Persistent);

var db = postgres.AddDatabase("min");

var keycloak = builder
    .AddKeycloak("keycloak", 8080)
    .WithDataVolume()
    .WithLifetime(ContainerLifetime.Persistent);

builder.AddProject<Api>("api")
    .WithReference(db)
    .WithReference(keycloak)
    .WaitFor(db)
    .WaitFor(keycloak);

builder.AddProject<Web>("web")
    .WithReference(keycloak)
    .WaitFor(keycloak);

builder.Build().Run();
