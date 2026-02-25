var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RFI_WordsTrainer_Web>("rfi-wordstrainer-web");

builder.Build().Run();
