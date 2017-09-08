@echo off
setlocal enabledelayedexpansion

set MSBUILD="c:\bin\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe"

dotnet restore src\MSBuild.sln 

%MSBUILD% /v:m  src\Framework\Microsoft.Build.Framework.csproj

%MSBUILD% /v:m  src\Build\Microsoft.Build.csproj

@PAUSE    