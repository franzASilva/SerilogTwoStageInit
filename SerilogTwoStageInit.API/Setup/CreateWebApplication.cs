using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Templates;

namespace SerilogTwoStageInit.API.Setup;

internal static class CreateWebApplication
{
    public static void Run(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var useJsonLog = builder.Configuration.GetValue<bool>("UseJsonLog");

        builder.Services.AddSerilog((services, lc) =>
        {
            lc
            .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
            .ReadFrom.Configuration(builder.Configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext()
            .Enrich.WithExceptionDetails();

            if (useJsonLog)
            {
                lc.WriteTo.Console(new ExpressionTemplate("{ {date: @t, level: @l, message: @m, exception: @x, properties: @p} }\n"));
            }
            else
            {
                lc.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] [{SourceContext}] {Message:lj}{NewLine}{Exception}");
            }
        });

        builder.Services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(Program).Assembly);
        });

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHealthChecks();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.DefaultModelsExpandDepth(-1); // removes schemas
            });
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.MapHealthChecks("/healthcheck");
        app.Run();
    }
}
