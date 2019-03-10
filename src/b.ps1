dotnet build MSBuild\MSBuild.csproj

mkdir $PWD/../../lib
dotnet build MSBuild\MSBuild.csproj -f netcoreapp2.1 -o $PWD/../../lib