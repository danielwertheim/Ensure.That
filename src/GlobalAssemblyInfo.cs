using System.Reflection;

#if DEBUG
[assembly: AssemblyProduct("Ensure.That (Debug)")]
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyProduct("Ensure.That (Release)")]
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyCompany("danielwertheim")]
[assembly: AssemblyCopyright("Copyright © 2016 Daniel Wertheim")]