@echo off
@REM https://dotnetcli.azureedge.net/dotnet/Sdk/2.1.401/dotnet-sdk-2.1.401-win-x64.zip
powershell -NoLogo -NoProfile -ExecutionPolicy ByPass -Command "& """%~dp0eng\common\build.ps1""" -build -restore %*"
exit /b %ErrorLevel%
