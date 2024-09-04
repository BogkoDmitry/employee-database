using EmployeeDatabase;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
    .Build();

await host.RunAsync();

