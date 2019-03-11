// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Build.Utilities
{
    [System.Diagnostics.DebuggerDisplayAttribute("DirectoryPath: {DirectoryPath}, TargetFrameworkVersion = {TargetFrameworkVersion}")]
    public partial class AssemblyFoldersFromConfigInfo
    {
        public AssemblyFoldersFromConfigInfo(string directoryPath, System.Version targetFrameworkVersion) { }
        public string DirectoryPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Version TargetFrameworkVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } }
    }
    public partial class CommandLineBuilder
    {
        public CommandLineBuilder() { }
        public CommandLineBuilder(bool quoteHyphensOnCommandLine) { }
        public CommandLineBuilder(bool quoteHyphensOnCommandLine, bool useNewLineSeparator) { }
        protected System.Text.StringBuilder CommandLine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Text.StringBuilder); } }
        public int Length { get { return default(int); } }
        public void AppendFileNameIfNotNull(Microsoft.Build.Framework.ITaskItem fileItem) { }
        public void AppendFileNameIfNotNull(string fileName) { }
        public void AppendFileNamesIfNotNull(Microsoft.Build.Framework.ITaskItem[] fileItems, string delimiter) { }
        public void AppendFileNamesIfNotNull(string[] fileNames, string delimiter) { }
        protected void AppendFileNameWithQuoting(string fileName) { }
        protected void AppendQuotedTextToBuffer(System.Text.StringBuilder buffer, string unquotedTextToAppend) { }
        protected void AppendSpaceIfNotEmpty() { }
        public void AppendSwitch(string switchName) { }
        public void AppendSwitchIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem parameter) { }
        public void AppendSwitchIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem[] parameters, string delimiter) { }
        public void AppendSwitchIfNotNull(string switchName, string parameter) { }
        public void AppendSwitchIfNotNull(string switchName, string[] parameters, string delimiter) { }
        public void AppendSwitchUnquotedIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem parameter) { }
        public void AppendSwitchUnquotedIfNotNull(string switchName, Microsoft.Build.Framework.ITaskItem[] parameters, string delimiter) { }
        public void AppendSwitchUnquotedIfNotNull(string switchName, string parameter) { }
        public void AppendSwitchUnquotedIfNotNull(string switchName, string[] parameters, string delimiter) { }
        public void AppendTextUnquoted(string textToAppend) { }
        protected void AppendTextWithQuoting(string textToAppend) { }
        protected virtual bool IsQuotingRequired(string parameter) { return default(bool); }
        public override string ToString() { return default(string); }
        protected virtual void VerifyThrowNoEmbeddedDoubleQuotes(string switchName, string parameter) { }
    }
    public enum DotNetFrameworkArchitecture
    {
        Bitness32 = 1,
        Bitness64 = 2,
        Current = 0,
    }
    public enum HostObjectInitializationStatus
    {
        NoActionReturnFailure = 3,
        NoActionReturnSuccess = 2,
        UseAlternateToolToExecute = 1,
        UseHostObjectToExecute = 0,
    }
    public abstract partial class Logger : Microsoft.Build.Framework.ILogger
    {
        protected Logger() { }
        public virtual string Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.LoggerVerbosity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string FormatErrorEvent(Microsoft.Build.Framework.BuildErrorEventArgs args) { return default(string); }
        public virtual string FormatWarningEvent(Microsoft.Build.Framework.BuildWarningEventArgs args) { return default(string); }
        public abstract void Initialize(Microsoft.Build.Framework.IEventSource eventSource);
        public bool IsVerbosityAtLeast(Microsoft.Build.Framework.LoggerVerbosity checkVerbosity) { return default(bool); }
        public virtual void Shutdown() { }
    }
    public enum MultipleVersionSupport
    {
        Allow = 0,
        Error = 2,
        Warning = 1,
    }
    public partial class MuxLogger : Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger
    {
        public MuxLogger() { }
        public bool IncludeEvaluationMetaprojects { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IncludeEvaluationProfiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IncludeTaskInputs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.LoggerVerbosity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int maxNodeCount) { }
        public void RegisterLogger(int submissionId, Microsoft.Build.Framework.ILogger logger) { }
        public void Shutdown() { }
        public bool UnregisterLoggers(int submissionId) { return default(bool); }
    }
    public static partial class ProcessorArchitecture
    {
        public const string AMD64 = "AMD64";
        public const string ARM = "ARM";
        public const string IA64 = "IA64";
        public const string MSIL = "MSIL";
        public const string X86 = "x86";
        public static string CurrentProcessArchitecture { get { return default(string); } }
    }
    public partial class SDKManifest
    {
        public SDKManifest(string pathToSdk) { }
        public System.Collections.Generic.IDictionary<string, string> AppxLocations { get { return default(System.Collections.Generic.IDictionary<string, string>); } }
        public string CopyRedistToSubDirectory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string DependsOnSDK { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Collections.Generic.IDictionary<string, string> FrameworkIdentities { get { return default(System.Collections.Generic.IDictionary<string, string>); } }
        public string FrameworkIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string MaxOSVersionTested { get { return default(string); } }
        public string MaxPlatformVersion { get { return default(string); } }
        public string MinOSVersion { get { return default(string); } }
        public string MinVSVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string MoreInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string PlatformIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string ProductFamilyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public bool ReadError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
        public string ReadErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public Microsoft.Build.Utilities.SDKType SDKType { get { return default(Microsoft.Build.Utilities.SDKType); } }
        public string SupportedArchitectures { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string SupportPrefer32Bit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public Microsoft.Build.Utilities.MultipleVersionSupport SupportsMultipleVersions { get { return default(Microsoft.Build.Utilities.MultipleVersionSupport); } }
        public string TargetPlatform { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string TargetPlatformMinVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public string TargetPlatformVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public static partial class Attributes
        {
            public const string APPX = "APPX";
            public const string AppxLocation = "AppxLocation";
            public const string CopyLocalExpandedReferenceAssemblies = "CopyLocalExpandedReferenceAssemblies";
            public const string CopyRedist = "CopyRedist";
            public const string CopyRedistToSubDirectory = "CopyRedistToSubDirectory";
            public const string DependsOnSDK = "DependsOn";
            public const string DisplayName = "DisplayName";
            public const string ExpandReferenceAssemblies = "ExpandReferenceAssemblies";
            public const string FrameworkIdentity = "FrameworkIdentity";
            public const string MaxOSVersionTested = "MaxOSVersionTested";
            public const string MaxPlatformVersion = "MaxPlatformVersion";
            public const string MinOSVersion = "MinOSVersion";
            public const string MinVSVersion = "MinVSVersion";
            public const string MoreInfo = "MoreInfo";
            public const string PlatformIdentity = "PlatformIdentity";
            public const string ProductFamilyName = "ProductFamilyName";
            public const string SDKType = "SDKType";
            public const string SupportedArchitectures = "SupportedArchitectures";
            public const string SupportPrefer32Bit = "SupportPrefer32Bit";
            public const string SupportsMultipleVersions = "SupportsMultipleVersions";
            public const string TargetedSDK = "TargetedSDKArchitecture";
            public const string TargetedSDKConfiguration = "TargetedSDKConfiguration";
            public const string TargetPlatform = "TargetPlatform";
            public const string TargetPlatformMinVersion = "TargetPlatformMinVersion";
            public const string TargetPlatformVersion = "TargetPlatformVersion";
        }
    }
    public enum SDKType
    {
        External = 1,
        Framework = 3,
        Platform = 2,
        Unspecified = 0,
    }
    public enum TargetDotNetFrameworkVersion
    {
        Latest = 9999,
        Version11 = 0,
        Version20 = 1,
        Version30 = 2,
        Version35 = 3,
        Version40 = 4,
        Version45 = 5,
        Version451 = 6,
        Version452 = 9,
        Version46 = 7,
        Version461 = 8,
        Version462 = 10,
        Version47 = 11,
        Version471 = 12,
        Version472 = 13,
        VersionLatest = 10,
    }
    public partial class TargetPlatformSDK : System.IEquatable<Microsoft.Build.Utilities.TargetPlatformSDK>
    {
        public TargetPlatformSDK(string targetPlatformIdentifier, System.Version targetPlatformVersion, string path) { }
        public string DisplayName { get { return default(string); } }
        public System.Version MinOSVersion { get { return default(System.Version); } }
        public System.Version MinVSVersion { get { return default(System.Version); } }
        public string Path { get { return default(string); } set { } }
        public string TargetPlatformIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Version TargetPlatformVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } }
        public bool ContainsPlatform(string targetPlatformIdentifier, string targetPlatformVersion) { return default(bool); }
        public bool Equals(Microsoft.Build.Utilities.TargetPlatformSDK other) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    public abstract partial class Task : Microsoft.Build.Framework.ITask
    {
        protected Task() { }
        protected Task(System.Resources.ResourceManager taskResources) { }
        protected Task(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
        public Microsoft.Build.Framework.IBuildEngine BuildEngine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.IBuildEngine); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Framework.IBuildEngine2 BuildEngine2 { get { return default(Microsoft.Build.Framework.IBuildEngine2); } }
        public Microsoft.Build.Framework.IBuildEngine3 BuildEngine3 { get { return default(Microsoft.Build.Framework.IBuildEngine3); } }
        public Microsoft.Build.Framework.IBuildEngine4 BuildEngine4 { get { return default(Microsoft.Build.Framework.IBuildEngine4); } }
        public Microsoft.Build.Framework.IBuildEngine5 BuildEngine5 { get { return default(Microsoft.Build.Framework.IBuildEngine5); } }
        protected string HelpKeywordPrefix { get { return default(string); } set { } }
        public Microsoft.Build.Framework.ITaskHost HostObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Framework.ITaskHost); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Utilities.TaskLoggingHelper Log { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Microsoft.Build.Utilities.TaskLoggingHelper); } }
        protected System.Resources.ResourceManager TaskResources { get { return default(System.Resources.ResourceManager); } set { } }
        public abstract bool Execute();
    }
    public sealed partial class TaskItem : Microsoft.Build.Framework.ITaskItem, Microsoft.Build.Framework.ITaskItem2
    {
        public TaskItem() { }
        public TaskItem(Microsoft.Build.Framework.ITaskItem sourceItem) { }
        public TaskItem(string itemSpec) { }
        public TaskItem(string itemSpec, System.Collections.IDictionary itemMetadata) { }
        public string ItemSpec { get { return default(string); } set { } }
        public int MetadataCount { get { return default(int); } }
        public System.Collections.ICollection MetadataNames { get { return default(System.Collections.ICollection); } }
        string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { get { return default(string); } set { } }
        public System.Collections.IDictionary CloneCustomMetadata() { return default(System.Collections.IDictionary); }
        public void CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem) { }
        public string GetMetadata(string metadataName) { return default(string); }
        System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped() { return default(System.Collections.IDictionary); }
        string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string metadataName) { return default(string); }
        void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue) { }
        public static explicit operator string (Microsoft.Build.Utilities.TaskItem taskItemToCast) { return default(string); }
        public void RemoveMetadata(string metadataName) { }
        public void SetMetadata(string metadataName, string metadataValue) { }
        public override string ToString() { return default(string); }
    }
    public partial class TaskLoggingHelper
    {
        public TaskLoggingHelper(Microsoft.Build.Framework.IBuildEngine buildEngine, string taskName) { }
        public TaskLoggingHelper(Microsoft.Build.Framework.ITask taskInstance) { }
        protected Microsoft.Build.Framework.IBuildEngine BuildEngine { get { return default(Microsoft.Build.Framework.IBuildEngine); } }
        public bool HasLoggedErrors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
        public string HelpKeywordPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected string TaskName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Resources.ResourceManager TaskResources { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Resources.ResourceManager); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ExtractMessageCode(string message, out string messageWithoutCodePrefix) { messageWithoutCodePrefix = default(string); return default(string); }
        public virtual string FormatResourceString(string resourceName, params object[] args) { return default(string); }
        public virtual string FormatString(string unformatted, params object[] args) { return default(string); }
        public virtual string GetResourceMessage(string resourceName) { return default(string); }
        public void LogCommandLine(Microsoft.Build.Framework.MessageImportance importance, string commandLine) { }
        public void LogCommandLine(string commandLine) { }
        public void LogCriticalMessage(string subcategory, string code, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params object[] messageArgs) { }
        public void LogError(string message, params object[] messageArgs) { }
        public void LogError(string subcategory, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params object[] messageArgs) { }
        public void LogErrorFromException(System.Exception exception) { }
        public void LogErrorFromException(System.Exception exception, bool showStackTrace) { }
        public void LogErrorFromException(System.Exception exception, bool showStackTrace, bool showDetail, string file) { }
        public void LogErrorFromResources(string messageResourceName, params object[] messageArgs) { }
        public void LogErrorFromResources(string subcategoryResourceName, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs) { }
        public void LogErrorWithCodeFromResources(string messageResourceName, params object[] messageArgs) { }
        public void LogErrorWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs) { }
        public void LogExternalProjectFinished(string message, string helpKeyword, string projectFile, bool succeeded) { }
        public void LogExternalProjectStarted(string message, string helpKeyword, string projectFile, string targetNames) { }
        public void LogMessage(Microsoft.Build.Framework.MessageImportance importance, string message, params object[] messageArgs) { }
        public void LogMessage(string message, params object[] messageArgs) { }
        public void LogMessage(string subcategory, string code, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, Microsoft.Build.Framework.MessageImportance importance, string message, params object[] messageArgs) { }
        public void LogMessageFromResources(Microsoft.Build.Framework.MessageImportance importance, string messageResourceName, params object[] messageArgs) { }
        public void LogMessageFromResources(string messageResourceName, params object[] messageArgs) { }
        public bool LogMessageFromText(string lineOfText, Microsoft.Build.Framework.MessageImportance messageImportance) { return default(bool); }
        public bool LogMessagesFromFile(string fileName) { return default(bool); }
        public bool LogMessagesFromFile(string fileName, Microsoft.Build.Framework.MessageImportance messageImportance) { return default(bool); }
        public bool LogMessagesFromStream(System.IO.TextReader stream, Microsoft.Build.Framework.MessageImportance messageImportance) { return default(bool); }
        public void LogTelemetry(string eventName, System.Collections.Generic.IDictionary<string, string> properties) { }
        public void LogWarning(string message, params object[] messageArgs) { }
        public void LogWarning(string subcategory, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params object[] messageArgs) { }
        public void LogWarningFromException(System.Exception exception) { }
        public void LogWarningFromException(System.Exception exception, bool showStackTrace) { }
        public void LogWarningFromResources(string messageResourceName, params object[] messageArgs) { }
        public void LogWarningFromResources(string subcategoryResourceName, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs) { }
        public void LogWarningWithCodeFromResources(string messageResourceName, params object[] messageArgs) { }
        public void LogWarningWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs) { }
    }
    public static partial class ToolLocationHelper
    {
        public static string CurrentToolsVersion { get { return default(string); } }
        public static string PathToSystem { get { return default(string); } }
        public static void ClearSDKStaticCache() { }
        public static System.Collections.Generic.IDictionary<string, string> FilterPlatformExtensionSDKs(System.Version targetPlatformVersion, System.Collections.Generic.IDictionary<string, string> extensionSdks) { return default(System.Collections.Generic.IDictionary<string, string>); }
        public static System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK> FilterTargetPlatformSdks(System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK> targetPlatformSdkList, System.Version osVersion, System.Version vsVersion) { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK>); }
        public static string FindRootFolderWhereAllFilesExist(string possibleRoots, string relativeFilePaths) { return default(string); }
        public static System.Collections.Generic.IList<Microsoft.Build.Utilities.AssemblyFoldersFromConfigInfo> GetAssemblyFoldersFromConfigInfo(string configFile, string targetFrameworkVersion, System.Reflection.ProcessorArchitecture targetProcessorArchitecture) { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.AssemblyFoldersFromConfigInfo>); }
        public static string GetDisplayNameForTargetFrameworkDirectory(string targetFrameworkDirectory, System.Runtime.Versioning.FrameworkName frameworkName) { return default(string); }
        public static string GetDotNetFrameworkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetDotNetFrameworkSdkInstallKeyValue(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetDotNetFrameworkSdkInstallKeyValue(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
        public static string GetDotNetFrameworkSdkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetDotNetFrameworkSdkRootRegistryKey(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
        public static string GetDotNetFrameworkVersionFolderPrefix(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static System.Collections.Generic.IEnumerable<string> GetFoldersInVSInstalls(System.Version minVersion=null, System.Version maxVersion=null, string subFolder=null) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static string GetFoldersInVSInstallsAsString(string minVersionString=null, string maxVersionString=null, string subFolder=null) { return default(string); }
        public static string GetLatestSDKTargetPlatformVersion(string sdkIdentifier, string sdkVersion) { return default(string); }
        public static string GetLatestSDKTargetPlatformVersion(string sdkIdentifier, string sdkVersion, string[] sdkRoots) { return default(string); }
        public static string GetPathToBuildTools(string toolsVersion) { return default(string); }
        public static string GetPathToBuildTools(string toolsVersion, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static string GetPathToBuildToolsFile(string fileName, string toolsVersion) { return default(string); }
        public static string GetPathToBuildToolsFile(string fileName, string toolsVersion, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static string GetPathToDotNetFramework(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetPathToDotNetFramework(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static string GetPathToDotNetFrameworkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetPathToDotNetFrameworkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static string GetPathToDotNetFrameworkReferenceAssemblies(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetPathToDotNetFrameworkSdk() { return default(string); }
        public static string GetPathToDotNetFrameworkSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetPathToDotNetFrameworkSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
        public static string GetPathToDotNetFrameworkSdkFile(string fileName) { return default(string); }
        public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version) { return default(string); }
        public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
        public static string GetPathToDotNetFrameworkSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static System.Collections.Generic.IList<string> GetPathToReferenceAssemblies(System.Runtime.Versioning.FrameworkName frameworkName) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetPathToReferenceAssemblies(string targetFrameworkRootPath, System.Runtime.Versioning.FrameworkName frameworkName) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetPathToReferenceAssemblies(string targetFrameworkRootPath, string targetFrameworkFallbackSearchPaths, System.Runtime.Versioning.FrameworkName frameworkName) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetPathToReferenceAssemblies(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetPathToReferenceAssemblies(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string targetFrameworkRootPath) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetPathToReferenceAssemblies(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string targetFrameworkRootPath, string targetFrameworkFallbackSearchPaths) { return default(System.Collections.Generic.IList<string>); }
        public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile) { return default(string); }
        public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string platformTarget) { return default(string); }
        public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string platformTarget, string targetFrameworkRootPath) { return default(string); }
        public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string platformTarget, string targetFrameworkRootPath, string targetFrameworkFallbackSearchPaths) { return default(string); }
        public static string GetPathToSystemFile(string fileName) { return default(string); }
        [System.ObsoleteAttribute("Consider using GetPlatformSDKLocation instead")]
        public static string GetPathToWindowsSdk(Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
        [System.ObsoleteAttribute("Consider using GetPlatformSDKLocationFile instead")]
        public static string GetPathToWindowsSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion) { return default(string); }
        [System.ObsoleteAttribute("Consider using GetPlatformSDKLocationFile instead")]
        public static string GetPathToWindowsSdkFile(string fileName, Microsoft.Build.Utilities.TargetDotNetFrameworkVersion version, Microsoft.Build.Utilities.VisualStudioVersion visualStudioVersion, Microsoft.Build.Utilities.DotNetFrameworkArchitecture architecture) { return default(string); }
        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion) { return default(string); }
        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string); }
        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string extensionDiskRoots, string registryRoot) { return default(string); }
        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(string); }
        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, System.Version targetPlatformVersion, string[] diskRoots, string registryRoot) { return default(string); }
        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, System.Version targetPlatformVersion, string[] diskRoots, string[] extensionDiskRoots, string registryRoot) { return default(string); }
        public static System.Collections.Generic.IDictionary<string, string> GetPlatformExtensionSDKLocations(string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<string, string>); }
        public static System.Collections.Generic.IDictionary<string, string> GetPlatformExtensionSDKLocations(string[] diskRoots, string registryRoot, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<string, string>); }
        public static System.Collections.Generic.IDictionary<string, string> GetPlatformExtensionSDKLocations(string[] diskRoots, string[] extensionDiskRoots, string registryRoot, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<string, string>); }
        public static System.Collections.Generic.IDictionary<string, System.Tuple<string, string>> GetPlatformExtensionSDKLocationsAndVersions(string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<string, System.Tuple<string, string>>); }
        public static System.Collections.Generic.IDictionary<string, System.Tuple<string, string>> GetPlatformExtensionSDKLocationsAndVersions(string[] diskRoots, string registryRoot, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<string, System.Tuple<string, string>>); }
        public static System.Collections.Generic.IDictionary<string, System.Tuple<string, string>> GetPlatformExtensionSDKLocationsAndVersions(string[] diskRoots, string[] multiPlatformDiskRoots, string registryRoot, string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(System.Collections.Generic.IDictionary<string, System.Tuple<string, string>>); }
        public static string[] GetPlatformOrFrameworkExtensionSdkReferences(string extensionSdkMoniker, string targetSdkIdentifier, string targetSdkVersion, string diskRoots, string extensionDiskRoots, string registryRoot) { return default(string[]); }
        public static string[] GetPlatformOrFrameworkExtensionSdkReferences(string extensionSdkMoniker, string targetSdkIdentifier, string targetSdkVersion, string diskRoots, string extensionDiskRoots, string registryRoot, string targetPlatformIdentifier, string targetPlatformVersion) { return default(string[]); }
        public static string GetPlatformSDKDisplayName(string targetPlatformIdentifier, string targetPlatformVersion) { return default(string); }
        public static string GetPlatformSDKDisplayName(string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string); }
        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, string targetPlatformVersion) { return default(string); }
        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string); }
        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, System.Version targetPlatformVersion) { return default(string); }
        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, System.Version targetPlatformVersion, string[] diskRoots, string registryRoot) { return default(string); }
        public static string GetPlatformSDKPropsFileLocation(string sdkIdentifier, string sdkVersion, string targetPlatformIdentifier, string targetPlatformMinVersion, string targetPlatformVersion) { return default(string); }
        public static string GetPlatformSDKPropsFileLocation(string sdkIdentifier, string sdkVersion, string targetPlatformIdentifier, string targetPlatformMinVersion, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string); }
        public static System.Collections.Generic.IEnumerable<string> GetPlatformsForSDK(string sdkIdentifier, System.Version sdkVersion) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> GetPlatformsForSDK(string sdkIdentifier, System.Version sdkVersion, string[] diskRoots, string registryRoot) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static string GetProgramFilesReferenceAssemblyRoot() { return default(string); }
        public static string GetSDKContentFolderPath(string sdkIdentifier, string sdkVersion, string targetPlatformIdentifier, string targetPlatformMinVersion, string targetPlatformVersion, string folderName, string diskRoot=null) { return default(string); }
        public static System.Collections.Generic.IList<string> GetSDKDesignTimeFolders(string sdkRoot) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetSDKDesignTimeFolders(string sdkRoot, string targetConfiguration, string targetArchitecture) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetSDKRedistFolders(string sdkRoot) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetSDKRedistFolders(string sdkRoot, string targetConfiguration, string targetArchitecture) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetSDKReferenceFolders(string sdkRoot) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetSDKReferenceFolders(string sdkRoot, string targetConfiguration, string targetArchitecture) { return default(System.Collections.Generic.IList<string>); }
        public static System.Collections.Generic.IList<string> GetSupportedTargetFrameworks() { return default(System.Collections.Generic.IList<string>); }
        public static string[] GetTargetPlatformReferences(string sdkIdentifier, string sdkVersion, string targetPlatformIdentifier, string targetPlatformMinVersion, string targetPlatformVersion) { return default(string[]); }
        public static string[] GetTargetPlatformReferences(string sdkIdentifier, string sdkVersion, string targetPlatformIdentifier, string targetPlatformMinVersion, string targetPlatformVersion, string diskRoots, string registryRoot) { return default(string[]); }
        public static System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK> GetTargetPlatformSdks() { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK>); }
        public static System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK> GetTargetPlatformSdks(string[] diskRoots, string registryRoot) { return default(System.Collections.Generic.IList<Microsoft.Build.Utilities.TargetPlatformSDK>); }
        public static System.Runtime.Versioning.FrameworkName HighestVersionOfTargetFrameworkIdentifier(string targetFrameworkRootDirectory, string frameworkIdentifier) { return default(System.Runtime.Versioning.FrameworkName); }
    }
    public abstract partial class ToolTask : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask
    {
        protected ToolTask() { }
        protected ToolTask(System.Resources.ResourceManager taskResources) { }
        protected ToolTask(System.Resources.ResourceManager taskResources, string helpKeywordPrefix) { }
        public bool EchoOff { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ObsoleteAttribute("Use EnvironmentVariables property")]
        protected virtual System.Collections.Generic.Dictionary<string, string> EnvironmentOverride { get { return default(System.Collections.Generic.Dictionary<string, string>); } }
        public string[] EnvironmentVariables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public int ExitCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
        protected virtual bool HasLoggedErrors { get { return default(bool); } }
        public bool LogStandardErrorAsError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected virtual System.Text.Encoding ResponseFileEncoding { get { return default(System.Text.Encoding); } }
        protected virtual System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } }
        public string StandardErrorImportance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected Microsoft.Build.Framework.MessageImportance StandardErrorImportanceToUse { get { return default(Microsoft.Build.Framework.MessageImportance); } }
        protected virtual Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
        protected virtual System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } }
        public string StandardOutputImportance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected Microsoft.Build.Framework.MessageImportance StandardOutputImportanceToUse { get { return default(Microsoft.Build.Framework.MessageImportance); } }
        protected virtual Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { return default(Microsoft.Build.Framework.MessageImportance); } }
        protected int TaskProcessTerminationTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int Timeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.Threading.ManualResetEvent ToolCanceled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.ManualResetEvent); } }
        public virtual string ToolExe { get { return default(string); } set { } }
        protected abstract string ToolName { get; }
        public string ToolPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool UseCommandProcessor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool YieldDuringToolExecution { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected virtual string AdjustCommandsForOperatingSystem(string input) { return default(string); }
        protected virtual bool CallHostObjectToExecute() { return default(bool); }
        public virtual void Cancel() { }
        protected void DeleteTempFile(string fileName) { }
        public override bool Execute() { return default(bool); }
        protected virtual int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands) { return default(int); }
        protected virtual string GenerateCommandLineCommands() { return default(string); }
        protected abstract string GenerateFullPathToTool();
        protected virtual string GenerateResponseFileCommands() { return default(string); }
        protected virtual System.Diagnostics.ProcessStartInfo GetProcessStartInfo(string pathToTool, string commandLineCommands, string responseFileSwitch) { return default(System.Diagnostics.ProcessStartInfo); }
        protected virtual string GetResponseFileSwitch(string responseFilePath) { return default(string); }
        protected virtual string GetWorkingDirectory() { return default(string); }
        protected virtual bool HandleTaskExecutionErrors() { return default(bool); }
        protected virtual Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { return default(Microsoft.Build.Utilities.HostObjectInitializationStatus); }
        protected virtual void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
        protected virtual void LogPathToTool(string toolName, string pathToTool) { }
        protected virtual void LogToolCommand(string message) { }
        protected virtual string ResponseFileEscape(string responseString) { return default(string); }
        protected virtual bool SkipTaskExecution() { return default(bool); }
        protected internal virtual bool ValidateParameters() { return default(bool); }
    }
    public static partial class TrackedDependencies
    {
        public static Microsoft.Build.Framework.ITaskItem[] ExpandWildcards(Microsoft.Build.Framework.ITaskItem[] expand) { return default(Microsoft.Build.Framework.ITaskItem[]); }
    }
    public enum VisualStudioVersion
    {
        Version100 = 0,
        Version110 = 1,
        Version120 = 2,
        Version140 = 3,
        Version150 = 4,
        VersionLatest = 4,
    }
}
