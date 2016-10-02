# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

**NuGet(dll)**

[![Nuget](https://img.shields.io/nuget/v/ensure.that.svg)](https://www.nuget.org/packages/ensure.that/)

## NuGet
Ensure.That is distributed via NuGet and since `v5.0.0` it's being built using DotNetCore and targes the frameworks:

* .NetStandard1.1
* .Net4.5+

```
install-package Ensure.That
```

## Samples (two different APIs)
Samples below just list one validation method, but the API contains validation methods for e.g.:

* Strings
* Numerics
* Collections (arrays, lists, collections, dictionaries)
* Booleans
* Guids

### Using static simple methods
This flavour was added in the `v5.0.0` release and **this is my prefered way**, because it has less overhead (read more below).

```csharp
EnsureArg.IsNotNullOrWhiteSpace(myString);
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
```

### Using extension methods
This is the initial way of doing validation, but **this IS NOT my prefered way**. Why? Well because it will
create a new instance of `Param<T>` wrapping the value being passed, so that the context-aware extension
methods can target correct type.

```csharp
Ensure.That(myString).IsNotNullOrWhiteSpace();
Ensure.That(myString, nameof(myArg)).IsNotNullOrWhiteSpace();
```

```csharp
Ensure
    .That(myString, nameof(myString))
    .WithExtraMessageOf(p => "Some more details")
    .IsNotNullOrWhiteSpace();
```

## Turn On/Off - default is On
Could be used with different profiles. Like `Debug` and `CI` is `On` while `Release` is `Off`.

```csharp
#if RELEASE
    Ensure.Off()
#endif
```

## Release notes
Available from `v2.0.0`, https://github.com/danielwertheim/ensure.that/blob/master/ReleaseNotes.md

# Get up and running with the source code #
The main solution is maintained using Visual Studio 2015.

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`:

```
dotnet test
```

## Issues, questions, etc.
So you have issues or questions... Great! That means someone is using it. Use the issues function here at the project page or contact me via mail: firstname@lastname.se; or Twitter: [@danielwertheim](https://twitter.com/danielwertheim)