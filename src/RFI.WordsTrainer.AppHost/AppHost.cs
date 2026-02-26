var builder = DistributedApplication.CreateBuilder(args);

// Add SQL Server container
var sqlServer = builder.AddSqlServer("sqlserver")
  .WithHostPort(60228)
  .WithLifetime(ContainerLifetime.Persistent);

// Add the database
var wordsTrainerDb = sqlServer.AddDatabase("rfi-wordstrainer-db");

// Add the web project with the database connection
builder.AddProject<Projects.RFI_WordsTrainer_Web>("rfi-wordstrainer-web")
  .WithReference(wordsTrainerDb)
  .WithEnvironment("ASPNETCORE_ENVIRONMENT", builder.Environment.EnvironmentName)
  .WaitFor(wordsTrainerDb);

builder.Build().Run();
