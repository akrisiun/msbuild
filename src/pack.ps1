
dotnet pack Build\Microsoft.Build.csproj                 -o $PWD --include-source
dotnet pack MSBuild\MSBuild.csproj                       -o $PWD --include-source
dotnet pack Utilities\Microsoft.Build.Utilities.csproj   -o $PWD --include-source
dotnet pack Tasks\Microsoft.Build.Tasks.csproj           -o $PWD --include-source