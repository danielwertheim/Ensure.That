# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

## NuGet
Ensure.That is distributed via [NuGet](https://www.nuget.org/packages/ensure.that/) and since `v6.0.0` it is developed as a .NET Standard project targetting v1.1

```
install-package Ensure.That
```

## Turn On/Off - default is On
Could be used with different profiles. Like `Debug` and `CI` is `On` while `Release` is `Off`.

```csharp
#if RELEASE
    Ensure.Off()
#endif
```

### Using static simple methods
The `EnsureArg` flavour was added in the `v5.0.0` release and **this is my prefered way**, because it has less overhead (read more below) and is the API that will continue to exist.

```csharp
EnsureArg.IsNotNullOrWhiteSpace(myString);
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
```

### Using extension methods
This is the initial way of doing validation, but **this IS NOT my prefered way**. Why? Well because it will
create a new instance of `Param<T>` wrapping the value being passed, so that the context-aware extension
methods can target correct type.

Since `v7.0.0` the `Ensure.That` flavour has been marked as `Obsolete` with a warning and will be removed in a future version.

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

```csharp
Ensure
    .That(myString, nameof(myString))
    .WithException(param => new Exception())
    .IsNotNullOrEmpty();
```

## Samples (two different APIs)
The Samples above just uses `string` validation, but there are more. E.g.:

* Strings
* Numerics
* Collections (arrays, lists, collections, dictionaries)
* Booleans
* Guids

## Release notes
Available from `v2.0.0`, https://github.com/danielwertheim/ensure.that/blob/master/ReleaseNotes.md

# Get up and running with the source code #
The main solution is maintained using Visual Studio 2017.

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`:

```
dotnet test
```

## Issues, questions, etc.
So you have issues or questions... Great! That means someone is using it. Use the issues function here at the project page or contact me via mail: firstname@lastname.se; or Twitter: [@danielwertheim](https://twitter.com/danielwertheim)
