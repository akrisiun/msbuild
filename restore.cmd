
set NUGET=nuget.exe
mkdir packages 

%NUGET%  install -outputDirectory packages Newtonsoft.Json -version 9.0.1
%NUGET%  install -outputDirectory packages Microsoft.DotNet.BuildTools.GenApi -version 1.0.0-beta-00081
%NUGET%  install -outputDirectory packages Nerdbank.GitVersioning -version 1.6.35

mkdir packages\Microsoft.DotNet.BuildTools.GenAPI\
mkdir packages\Nerdbank.GitVersioning\1.6.35

set VisualStudioVersion=15.0
set MSBUILD_ARGS="%~dp0build.proj" /m /verbosity:minimal %*
set MSBUILD_ARGS=%MSBUILD_ARGS% /fileloggerparameters:Verbosity=diag;LogFile="%MSBUILDLOGPATH%"

nuget restore src\MSBuild.sln

@PAUSE