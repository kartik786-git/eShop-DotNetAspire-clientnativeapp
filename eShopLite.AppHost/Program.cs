var builder = DistributedApplication.CreateBuilder(args);



//backend
var backend = builder.AddProject<Projects.Products>("products");

//forntend
builder.AddProject<Projects.Store>("store").WithReference(backend);


builder.Build().Run();
