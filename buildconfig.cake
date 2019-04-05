public class BuildConfig
{
    private const string Version = "8.1.1";
    private const bool IsPreRelease = true;

    public readonly string SrcDir = "./src/";
    public readonly string ArtifactsDir = "./artifacts/";    
    public readonly string TestResultsDir = "./testresults/";
    public readonly bool SignAssemblies = true;
    public readonly string SignKeyPath = "./ensure.that.snk";

    public string Target { get; private set; }
    public string SemVer { get; private set; }
    public string BuildVersion { get; private set; }
    public string BuildProfile { get; private set; }

    public static BuildConfig Create(
        ICakeContext context,
        BuildSystem buildSystem)
    {
        if (context == null)
            throw new ArgumentNullException("context");

        var buildRevision = context.Argument("buildrevision", "0");

        return new BuildConfig
        {
            Target = context.Argument("target", "Default"),
            SemVer = Version + (IsPreRelease ? $"-pre{buildRevision}" : string.Empty),
            BuildVersion = Version + "." + buildRevision,
            BuildProfile = context.Argument("configuration", "Release")
        };
    }
}
