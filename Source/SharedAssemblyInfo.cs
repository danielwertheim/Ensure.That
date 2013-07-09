using System.Reflection;

#if DEBUG
[assembly: AssemblyProduct("Ensure.That (Debug)")]
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyProduct("Ensure.That (Release)")]
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyDescription("Yet another guard clause project.")]
[assembly: AssemblyCompany("Daniel Wertheim")]
[assembly: AssemblyCopyright("Copyright © Daniel Wertheim")]
[assembly: AssemblyTrademark("")]

[assembly: AssemblyVersion("0.10.1.*")]
[assembly: AssemblyFileVersion("0.10.1")]