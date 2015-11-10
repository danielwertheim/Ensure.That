# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

**NuGet(dll)**

[![Nuget](https://img.shields.io/nuget/v/ensure.that.svg)](https://www.nuget.org/packages/ensure.that/) [![Users](https://img.shields.io/nuget/dt/ensure.that.svg)](https://www.nuget.org/packages/ensure.that/)

**NuGet(src)**

[![Nuget](https://img.shields.io/nuget/v/ensure.that.source.svg)](https://www.nuget.org/packages/ensure.that.source/) [![Users](https://img.shields.io/nuget/dt/ensure.that.source.svg)](https://www.nuget.org/packages/ensure.that.source/)

## Turn On/Off - default is On
Could be used with different profiles. Like `Debug` and `CI` is `On` while `Release` is `Off`.

```csharp
#if RELEASE
    Ensure.Off()
#endif
```

## Samples
```csharp
Ensure.That(myString, nameof(myArg)).IsNotNullOrWhiteSpace();

Ensure.That(myString, "myArg").IsNotNullOrWhiteSpace();
```

**NOTE!** I personally would not use the lambda version below to get the name of the argument. I would rather use the `nameof` [construct](https://msdn.microsoft.com/en-us/library/dn986596.aspx) or manually defining the name of the argument.

From `v3.1.0` support for lambdas to extract the param-name and/or value has been added, hence you can now do:

```csharp
//Note! Makes a compile of the lambda to get the value. Also extracts the param name "person.Name" from the expression.
Ensure.That(() => person.Name).IsNotNullOrWhiteSpace();

//Note! Makes a compile of the lambda to get the value. Does NOT extract the param name "person.Name" from the expression.
Ensure.That(() => person.Name, "The name param").IsNotNullOrWhiteSpace();

//Note! Does NOT make a compile of the lambda. Only parses the expression to get the param name "person.Name" from the expression.
Ensure.That(person.Name, () => person.Name).IsNotNullOrWhiteSpace();
```

## Release notes ##
Available from `v2.0.0`, https://github.com/danielwertheim/Ensure.That/wiki/Release-notes

## Portable libary or Source via NuGet #
Ensure.That is distributed via NuGet. Either [as a portable library](http://nuget.org/packages/ensure.that) (`for .Net4+, Silverlight, Windows Phone, WinRT`) or as [an includable source package](http://nuget.org/packages/ensure.that.source).

### vNext ###
Since `v3.0.0` there's included support for **vNext**.

## Documentation ##
The documentation is contained in the [project wiki](https://github.com/danielwertheim/ensure.that/wiki).

# Get up and running with the source code #
The main solution is maintained using Visual Studio 2015.

Please note. **No NuGet packages are checked in**. If you are using the latest version of NuGet (v2.7.1+) **you should be able to just build and the packages will be restored**. If this does not work, you could install the missing NuGet packages using a simple PowerShell script [as covered here](http://danielwertheim.se/2013/08/12/nuget-restore-powershell-vs-rake)

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`.

## Deploy ##
There's a `gulp.js` file under `.\deploy`. It requires that you have `nuget.exe` in your path. Other than that, you should be able to run the tasks to restore tools, build, run tests and pack NuPkgs.

## How-to Contribute ##
This is described in the wiki, under: ["How-to Contribute"](https://github.com/danielwertheim/Ensure.That/wiki/how-to-contribute).

Pull request should be against the `develop` **branch**

## Issues, questions, etc ##
So you have issues or questions... Great! That means someone is using it. Use the issues function here at the project page or contact me via mail: firstname@lastname.se; or Twitter: [@danielwertheim](https://twitter.com/danielwertheim)