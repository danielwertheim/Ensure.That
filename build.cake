#load "./buildconfig.cake"

var config = BuildConfig.Create(Context, BuildSystem);

Information("Branch: " + config.Branch);
Information("BuildProfile: " + config.BuildProfile);
Information("SemVer: " + config.SemVer);

Task("Default")
    .IsDependentOn("InitOutDir")
    .IsDependentOn("Restore")
    .IsDependentOn("Bump")
    .IsDependentOn("Build")
    .IsDependentOn("UnitTest");

Task("CI")
    .IsDependentOn("Default")
    .IsDependentOn("Pack");

Task("InitOutDir")
    .Does(() => {
        EnsureDirectoryExists(config.OutDir);
        CleanDirectory(config.OutDir);
    });

Task("Bump")
    .Does(() => {
        var files = GetFiles(config.SrcDir + "projects/**/project.json");
        foreach(var file in files)
        {
            Information("Processing: {0}", file);

            var path = file.ToString();
            var trg = new StringBuilder();
            var regExVersion = new System.Text.RegularExpressions.Regex("\"version\":(\\s)?\"0.0.0-\\*\",");
            using (var src = System.IO.File.OpenRead(path))
            {
                using (var reader = new StreamReader(src))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if(line == null)
                            continue;

                        line = regExVersion.Replace(line, string.Format("\"version\": \"{0}\",", config.SemVer));

                        trg.AppendLine(line);
                    }
                }
            }

            System.IO.File.WriteAllText(path, trg.ToString());
        }
    });
    
Task("Restore")
    .Does(() => DotNetCoreRestore(config.SrcDir));

Task("Build")
    .Does(() => DotNetCoreBuild(
        config.SrcDir + "**/project.json",
        new DotNetCoreBuildSettings {
            Configuration = config.BuildProfile
        }));

Task("UnitTest").Does(() => {
    var settings = new DotNetCoreTestSettings {
        Configuration = config.BuildProfile
    };
    foreach(var testProj in GetFiles(config.SrcDir + "tests/**/*.UnitTests/project.json")) {
        DotNetCoreTest(testProj.FullPath, settings);
    }
});

Task("Pack").Does(() => {
    foreach(var proj in GetFiles(config.SrcDir + "projects/**/project.json")) {
        DotNetCorePack(proj.FullPath, new DotNetCorePackSettings {
            Configuration = config.BuildProfile,
            OutputDirectory = config.OutDir
        });
    }
});

RunTarget(config.Target);