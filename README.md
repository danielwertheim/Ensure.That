# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

**NuGet(dll)**

[![Nuget](https://img.shields.io/nuget/v/ensure.that.svg)](https://www.nuget.org/packages/ensure.that/)

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

## Release notes
Available from `v2.0.0`, https://github.com/danielwertheim/ensure.that/blob/master/ReleaseNotes.md

## NuGet
Ensure.That is distributed via NuGet and since `v5.0.0` it's being build using DotNetCore and targes the frameworks:

* .NetStandard1.1
* .Net4.5+

## Documentation
The documentation is contained in the [project wiki](https://github.com/danielwertheim/ensure.that/wiki).

# Get up and running with the source code #
The main solution is maintained using Visual Studio 2015.

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`:

```
dotnet test
```

## Deploy
Needs info as switching for Cake build.

## Issues, questions, etc.
So you have issues or questions... Great! That means someone is using it. Use the issues function here at the project page or contact me via mail: firstname@lastname.se; or Twitter: [@danielwertheim](https://twitter.com/danielwertheim)