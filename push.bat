echo off
dotnet nuget push AspNetCore.SignalR.RabbitMQ\bin\Release\*.nupkg --api-key %1 --source https://api.nuget.org/v3/index.json