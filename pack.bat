@echo off

set tag=%1
if [%tag%]==[] (
  for /f %%i in ('git describe --tags --abbrev^=0 --match v[0-9]*') do set tag=%%i
)
echo tag: %tag%

if [%tag%]==[] (
  rem set default version
  set version=0.1.0
) else (
  set version=%tag:~1%
)
echo version: %version%

dotnet pack AspNetCore.SignalR.RabbitMQ -c Release -p:Version=%version%