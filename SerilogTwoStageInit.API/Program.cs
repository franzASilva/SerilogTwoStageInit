using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using SerilogTwoStageInit.API.Setup;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .Enrich.WithExceptionDetails()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting web application");

    CreateWebApplication.Run(args);
}
catch (Exception ex)
{
    Log.Fatal(ex, "An exception thrown during set-up of the ASP.NET Core host");
}
finally
{
    Log.CloseAndFlush();
}
