
set NUGET=nuget.exe
mkdir packages 

%NUGET%  install -outputDirectory packages Newtonsoft.Json -version 9.0.1
%NUGET%  install -outputDirectory packages System.Threading.Tasks.Dataflow -version 4.5.24

System.Threading.Tasks.Dataflow, Version=4.5.24.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a

   at Microsoft.Build.BackEnd.Logging.LoggingService.ProcessLoggingEvent(Object buildEvent, Boolean allowThrottling)
   at Microsoft.Build.BackEnd.Logging.LoggingService.LogBuildEvent(BuildEventArgs buildEvent) in c:\Beta\src2\msbuild\src\Build\BackEnd\Components\Logging\LoggingService.cs:line 1012
   at Microsoft.Build.BackEnd.Logging.LoggingContext.LogBuildEvent(BuildEventArgs buildEvent) in c:\Beta\src2\msbuild\src\Build\BackEnd\Components\Logging\LoggingContext.cs:line 228
   at Microsoft.Build.Evaluation.Evaluator`4.Evaluate(ILoggingService loggingService, BuildEventContext buildEventContext) in c:\Beta\src2\msbuild\src\Build\Evaluation\Evaluator.cs:line 780
   at Microsoft.Build.Evaluation.Evaluator`4.Evaluate(IEvaluatorData`4 data, ProjectRootElement root, ProjectLoadSettings loadSettings, Int32 maxNodeCount, PropertyDictionary`1 environmentProperties, ILoggingService loggingService, IItemFactory`2 itemFactory, IToolsetProvider toolsetProvider, ProjectRootElementCache projectRootElementCache, BuildEventContext buildEventContext, ProjectInstance projectInstanceIfAnyForDebuggerOnly, SdkResolution sdkResolution) in c:\Beta\src2\msbuild\src\Build\Evaluation\Evaluator.cs:line 387
   at Microsoft.Build.Evaluation.Project.Reevaluate(ILoggingService loggingServiceForEvaluation, ProjectLoadSettings loadSettings) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 2640
   at Microsoft.Build.Evaluation.Project.ReevaluateIfNecessary(ILoggingService loggingServiceForEvaluation, ProjectLoadSettings loadSettings) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 2617
   at Microsoft.Build.Evaluation.Project.ReevaluateIfNecessary(ILoggingService loggingServiceForEvaluation) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 2602
   at Microsoft.Build.Evaluation.Project.ReevaluateIfNecessary() in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 2074
   at Microsoft.Build.Evaluation.Project.Initialize(IDictionary`2 globalProperties, String toolsVersion, String subToolsetVersion, ProjectLoadSettings loadSettings) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 2705
   at Microsoft.Build.Evaluation.Project..ctor(ProjectRootElement xml, IDictionary`2 globalProperties, String toolsVersion, String subToolsetVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 295
   at Microsoft.Build.Evaluation.Project..ctor(ProjectRootElement xml, IDictionary`2 globalProperties, String toolsVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 269
   at Microsoft.Build.Evaluation.Project..ctor(ProjectRootElement xml, IDictionary`2 globalProperties, String toolsVersion, ProjectCollection projectCollection) in c:\Beta\src2\msbuild\src\Build\Definition\Project.cs:line 252
   at Microsoft.CodeAnalysis.MSBuild.ProjectFileLoader.<LoadProjectAsync>d__6.MoveNext()
   

%NUGET%  install -outputDirectory packages Microsoft.DotNet.BuildTools.GenApi -version 1.0.0-beta2-00731-01
%NUGET%  install -outputDirectory packages Nerdbank.GitVersioning -version 1.6.35

mkdir packages\Microsoft.DotNet.BuildTools.GenAPI\
mkdir packages\Microsoft.DotNet.BuildTools.GenAPI\1.0.0-beta2-00731-01
mkdir packages\Nerdbank.GitVersioning\1.6.35

set VisualStudioVersion=15.0
set MSBUILD_ARGS="%~dp0build.proj" /m /verbosity:minimal %*
set MSBUILD_ARGS=%MSBUILD_ARGS% /fileloggerparameters:Verbosity=diag;LogFile="%MSBUILDLOGPATH%"

nuget restore src\MSBuild.sln

@PAUSE