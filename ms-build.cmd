@echo off
setlocal enabledelayedexpansion

set MSBUILD="c:\bin\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe"
@REM set MSBUILD="c:\Program Files (x86)\MSBuild\15.0\Bin\MSBuild.exe"
@REM dotnet restore src\MSBuild.sln 

@REM %MSBUILD% /v:m  src\Framework\Microsoft.Build.Framework.csproj

@REM %MSBUILD% /v:m  
dotnet build src\Build\Microsoft.Build.csproj

@PAUSE    