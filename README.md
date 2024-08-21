# Shows how to configure Serilog immediately when the application starts.
**This has the benefit of catching and reporting exceptions thrown during set-up of the ASP.NET Core host.**
**CorrelationId to track all the logs belonging to the same request**
- [.NET 8](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8/overview);
- [MediatR](https://github.com/jbogard/MediatR)


**Exceptions thrown during set-up**
![image](https://github.com/user-attachments/assets/dd7eaad0-4f1b-4dc2-bc9d-0f00e1a45862)


**Testing - appsettings.json -> "UseJsonLog": false**
![image](https://github.com/user-attachments/assets/9ab7e5b1-acbd-40b5-9b5e-8d66e0af30c0)


**Testing - appsettings.json -> "UseJsonLog": true**
![image](https://github.com/user-attachments/assets/065f6afd-1b47-4a94-8ffd-4b20b1a114c5)

```
{
    "date": "2024-08-20T22:19:30.4766424-03:00",
    "level": "Information",
    "message": "Now listening on: https://localhost:7251",
    "properties": {
        "address": "https://localhost:7251",
        "EventId": {
            "Id": 14,
            "Name": "ListeningOnAddress"
        },
        "SourceContext": "Microsoft.Hosting.Lifetime"
    }
}{
    "date": "2024-08-20T22:19:30.4885535-03:00",
    "level": "Information",
    "message": "Now listening on: http://localhost:5214",
    "properties": {
        "address": "http://localhost:5214",
        "EventId": {
            "Id": 14,
            "Name": "ListeningOnAddress"
        },
        "SourceContext": "Microsoft.Hosting.Lifetime"
    }
}{
    "date": "2024-08-20T22:19:30.5585973-03:00",
    "level": "Information",
    "message": "Application started. Press Ctrl+C to shut down.",
    "properties": {
        "SourceContext": "Microsoft.Hosting.Lifetime"
    }
}{
    "date": "2024-08-20T22:19:30.5599663-03:00",
    "level": "Information",
    "message": "Hosting environment: Development",
    "properties": {
        "EnvName": "Development",
        "SourceContext": "Microsoft.Hosting.Lifetime"
    }
}{
    "date": "2024-08-20T22:19:30.5602099-03:00",
    "level": "Information",
    "message": "Content root path: \\source\\repos\\SerilogTwoStageInit\\SerilogTwoStageInit.API",
    "properties": {
        "ContentRoot": "\\source\\repos\\SerilogTwoStageInit\\SerilogTwoStageInit.API",
        "SourceContext": "Microsoft.Hosting.Lifetime"
    }
}{
    "date": "2024-08-20T22:19:31.4969720-03:00",
    "level": "Information",
    "message": "Request starting HTTP/2 GET https://localhost:7251/swagger/index.html - null null",
    "properties": {
        "Protocol": "HTTP/2",
        "Method": "GET",
        "ContentType": null,
        "ContentLength": null,
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/swagger/index.html",
        "QueryString": "",
        "EventId": {
            "Id": 1
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:0000000F",
        "RequestPath": "/swagger/index.html",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "d3a7bb5c-3ca0-47ed-97a1-206eec4e3ce6"
    }
}{
    "date": "2024-08-20T22:19:31.8274115-03:00",
    "level": "Information",
    "message": "Request finished HTTP/2 GET https://localhost:7251/swagger/index.html - 200 null text/html;charset=utf-8 339,1696ms",
    "properties": {
        "ElapsedMilliseconds": 339.1696,
        "StatusCode": 200,
        "ContentType": "text/html;charset=utf-8",
        "ContentLength": null,
        "Protocol": "HTTP/2",
        "Method": "GET",
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/swagger/index.html",
        "QueryString": "",
        "EventId": {
            "Id": 2
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:0000000F",
        "RequestPath": "/swagger/index.html",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "d3a7bb5c-3ca0-47ed-97a1-206eec4e3ce6"
    }
}{
    "date": "2024-08-20T22:19:31.9080423-03:00",
    "level": "Information",
    "message": "Request starting HTTP/2 GET https://localhost:7251/swagger/index.js - null null",
    "properties": {
        "Protocol": "HTTP/2",
        "Method": "GET",
        "ContentType": null,
        "ContentLength": null,
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/swagger/index.js",
        "QueryString": "",
        "EventId": {
            "Id": 1
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000011",
        "RequestPath": "/swagger/index.js",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "f16518ec-9f9f-4d3f-81b0-e4494107305a"
    }
}{
    "date": "2024-08-20T22:19:31.9080424-03:00",
    "level": "Information",
    "message": "Request starting HTTP/2 GET https://localhost:7251/_vs/browserLink - null null",
    "properties": {
        "Protocol": "HTTP/2",
        "Method": "GET",
        "ContentType": null,
        "ContentLength": null,
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/_vs/browserLink",
        "QueryString": "",
        "EventId": {
            "Id": 1
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000013",
        "RequestPath": "/_vs/browserLink",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "4f170565-8f79-45ef-b0fd-5f84b26377f0"
    }
}{
    "date": "2024-08-20T22:19:31.9087463-03:00",
    "level": "Information",
    "message": "Request starting HTTP/2 GET https://localhost:7251/_framework/aspnetcore-browser-refresh.js - null null",
    "properties": {
        "Protocol": "HTTP/2",
        "Method": "GET",
        "ContentType": null,
        "ContentLength": null,
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/_framework/aspnetcore-browser-refresh.js",
        "QueryString": "",
        "EventId": {
            "Id": 1
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000015",
        "RequestPath": "/_framework/aspnetcore-browser-refresh.js",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "e7dd9406-b1ea-4fad-a72f-18b80fdf25c1"
    }
}{
    "date": "2024-08-20T22:19:31.9158877-03:00",
    "level": "Information",
    "message": "Request finished HTTP/2 GET https://localhost:7251/swagger/index.js - 200 null application/javascript;charset=utf-8 8,1441ms",
    "properties": {
        "ElapsedMilliseconds": 8.1441,
        "StatusCode": 200,
        "ContentType": "application/javascript;charset=utf-8",
        "ContentLength": null,
        "Protocol": "HTTP/2",
        "Method": "GET",
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/swagger/index.js",
        "QueryString": "",
        "EventId": {
            "Id": 2
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000011",
        "RequestPath": "/swagger/index.js",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "f16518ec-9f9f-4d3f-81b0-e4494107305a"
    }
}{
    "date": "2024-08-20T22:19:31.9425770-03:00",
    "level": "Information",
    "message": "Request finished HTTP/2 GET https://localhost:7251/_framework/aspnetcore-browser-refresh.js - 200 13782 application/javascript; charset=utf-8 33,863ms",
    "properties": {
        "ElapsedMilliseconds": 33.863,
        "StatusCode": 200,
        "ContentType": "application/javascript; charset=utf-8",
        "ContentLength": 13782,
        "Protocol": "HTTP/2",
        "Method": "GET",
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/_framework/aspnetcore-browser-refresh.js",
        "QueryString": "",
        "EventId": {
            "Id": 2
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000015",
        "RequestPath": "/_framework/aspnetcore-browser-refresh.js",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "e7dd9406-b1ea-4fad-a72f-18b80fdf25c1"
    }
}{
    "date": "2024-08-20T22:19:31.9963309-03:00",
    "level": "Information",
    "message": "Request finished HTTP/2 GET https://localhost:7251/_vs/browserLink - 200 null text/javascript; charset=UTF-8 88,4573ms",
    "properties": {
        "ElapsedMilliseconds": 88.4573,
        "StatusCode": 200,
        "ContentType": "text/javascript; charset=UTF-8",
        "ContentLength": null,
        "Protocol": "HTTP/2",
        "Method": "GET",
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/_vs/browserLink",
        "QueryString": "",
        "EventId": {
            "Id": 2
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000013",
        "RequestPath": "/_vs/browserLink",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "4f170565-8f79-45ef-b0fd-5f84b26377f0"
    }
}{
    "date": "2024-08-20T22:19:32.1384475-03:00",
    "level": "Information",
    "message": "Request starting HTTP/2 GET https://localhost:7251/swagger/v1/swagger.json - null null",
    "properties": {
        "Protocol": "HTTP/2",
        "Method": "GET",
        "ContentType": null,
        "ContentLength": null,
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/swagger/v1/swagger.json",
        "QueryString": "",
        "EventId": {
            "Id": 1
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000017",
        "RequestPath": "/swagger/v1/swagger.json",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "80abbaa1-6134-435b-91f8-61aa1872b1b1"
    }
}{
    "date": "2024-08-20T22:19:32.3358034-03:00",
    "level": "Information",
    "message": "Request finished HTTP/2 GET https://localhost:7251/swagger/v1/swagger.json - 200 null application/json;charset=utf-8 197,7403ms",
    "properties": {
        "ElapsedMilliseconds": 197.7403,
        "StatusCode": 200,
        "ContentType": "application/json;charset=utf-8",
        "ContentLength": null,
        "Protocol": "HTTP/2",
        "Method": "GET",
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/swagger/v1/swagger.json",
        "QueryString": "",
        "EventId": {
            "Id": 2
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000017",
        "RequestPath": "/swagger/v1/swagger.json",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "80abbaa1-6134-435b-91f8-61aa1872b1b1"
    }
}{
    "date": "2024-08-20T22:19:54.7456871-03:00",
    "level": "Information",
    "message": "Request starting HTTP/2 GET https://localhost:7251/api/Dummy - null null",
    "properties": {
        "Protocol": "HTTP/2",
        "Method": "GET",
        "ContentType": null,
        "ContentLength": null,
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/api/Dummy",
        "QueryString": "",
        "EventId": {
            "Id": 1
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.7535487-03:00",
    "level": "Information",
    "message": "Executing endpoint 'SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)'",
    "properties": {
        "EndpointName": "SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)",
        "EventId": {
            "Name": "ExecutingEndpoint"
        },
        "SourceContext": "Microsoft.AspNetCore.Routing.EndpointMiddleware",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.7810550-03:00",
    "level": "Information",
    "message": "Route matched with {action = \"Get\", controller = \"Dummy\"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.IActionResult] Get(MediatR.IMediator, System.Threading.CancellationToken) on controller SerilogTwoStageInit.API.Controllers.DummyController (SerilogTwoStageInit.API).",
    "properties": {
        "RouteData": "{action = \"Get\", controller = \"Dummy\"}",
        "MethodInfo": "System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.IActionResult] Get(MediatR.IMediator, System.Threading.CancellationToken)",
        "Controller": "SerilogTwoStageInit.API.Controllers.DummyController",
        "AssemblyName": "SerilogTwoStageInit.API",
        "EventId": {
            "Id": 102,
            "Name": "ControllerActionExecuting"
        },
        "SourceContext": "Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker",
        "ActionId": "9dc98ceb-4cd7-4342-a85c-fec853bc8367",
        "ActionName": "SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.8082165-03:00",
    "level": "Information",
    "message": "GetDummies",
    "properties": {
        "SourceContext": "SerilogTwoStageInit.API.QueryHandlers.GetAllQueryHandler",
        "ActionId": "9dc98ceb-4cd7-4342-a85c-fec853bc8367",
        "ActionName": "SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.8295138-03:00",
    "level": "Information",
    "message": "Executing OkObjectResult, writing value of type 'SerilogTwoStageInit.Domain.Models.DummyModel[]'.",
    "properties": {
        "ObjectResultType": "OkObjectResult",
        "Type": "SerilogTwoStageInit.Domain.Models.DummyModel[]",
        "EventId": {
            "Id": 1,
            "Name": "ObjectResultExecuting"
        },
        "SourceContext": "Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor",
        "ActionId": "9dc98ceb-4cd7-4342-a85c-fec853bc8367",
        "ActionName": "SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.8529403-03:00",
    "level": "Information",
    "message": "Executed action SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API) in 66,0927ms",
    "properties": {
        "ActionName": "SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)",
        "ElapsedMilliseconds": 66.0927,
        "EventId": {
            "Id": 105,
            "Name": "ActionExecuted"
        },
        "SourceContext": "Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.8545009-03:00",
    "level": "Information",
    "message": "Executed endpoint 'SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)'",
    "properties": {
        "EndpointName": "SerilogTwoStageInit.API.Controllers.DummyController.Get (SerilogTwoStageInit.API)",
        "EventId": {
            "Id": 1,
            "Name": "ExecutedEndpoint"
        },
        "SourceContext": "Microsoft.AspNetCore.Routing.EndpointMiddleware",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}{
    "date": "2024-08-20T22:19:54.8571179-03:00",
    "level": "Information",
    "message": "Request finished HTTP/2 GET https://localhost:7251/api/Dummy - 200 null application/json; charset=utf-8 111,8886ms",
    "properties": {
        "ElapsedMilliseconds": 111.8886,
        "StatusCode": 200,
        "ContentType": "application/json; charset=utf-8",
        "ContentLength": null,
        "Protocol": "HTTP/2",
        "Method": "GET",
        "Scheme": "https",
        "Host": "localhost:7251",
        "PathBase": "",
        "Path": "/api/Dummy",
        "QueryString": "",
        "EventId": {
            "Id": 2
        },
        "SourceContext": "Microsoft.AspNetCore.Hosting.Diagnostics",
        "RequestId": "0HN61FT7EVMT8:00000019",
        "RequestPath": "/api/Dummy",
        "ConnectionId": "0HN61FT7EVMT8",
        "CorrelationId": "b7fc518c-0488-4b74-8c38-02142b04ab34"
    }
}
```

