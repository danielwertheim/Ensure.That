public class BuildConfig
{
    private const string Version = "7.2.1";

    public readonly string SrcDir = "./src/";
    public readonly string OutDir = "./build/";    
    
    public bool IsDefaultBranch { get; private set; }
    public string Target { get; private set; }
    public string SemVer { get; private set; }
    public string BuildVersion { get; private set; }
    public string BuildProfile { get; private set; }
    public bool IsTeamCityBuild { get; private set; }
    
    public static BuildConfig Create(
        ICakeContext context,
        BuildSystem buildSystem)
    {
        if (context == null)
            throw new ArgumentNullException("context");

        var branch = context.Argument("branch", "master");
        var isDefaultBranch = branch.ToLower() == "master";
        var buildRevision = context.Argument("buildrevision", "0");

        return new BuildConfig
        {
            IsDefaultBranch = isDefaultBranch,
            Target = context.Argument("target", "Default"),
            SemVer = Version + (isDefaultBranch ? string.Empty : "-pre" + buildRevision),
            BuildVersion = Version + "." + buildRevision,
            BuildProfile = context.Argument("configuration", "Release"),
            IsTeamCityBuild = buildSystem.TeamCity.IsRunningOnTeamCity
        };
    }
}
