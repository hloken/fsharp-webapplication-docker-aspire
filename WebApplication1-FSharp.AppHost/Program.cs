var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApplication1_FSharp>("webapplication1-fsharp");

builder.Build().Run();
