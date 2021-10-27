# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

Developed for: .NET4.6.2, .NET5.0, .NET Standard 2.0 and 2.1 available via [NuGet](https://www.nuget.org/packages/ensure.that/).

[![Build Status](https://dev.azure.com/daniel-wertheim/os/_apis/build/status/Ensure.That-CI?branchName=master)](https://dev.azure.com/daniel-wertheim/os/_build/latest?definitionId=1&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/ensure.that.svg)](http://nuget.org/packages/ensure.that)

## Ensure.That - Using extension methods

```csharp
Ensure.That(myString).IsNotNullOrWhiteSpace();
Ensure.That(myString, nameof(myArg)).IsNotNullOrWhiteSpace();
Ensure.That(myString, nameof(myArg), (in EnsureOptions opts) => opts.WithMessage("Foo")).IsNotNullOrWhiteSpace();
```

Chainable:

```csharp
Ensure
.That(myString)
.IsNotNullOrWhiteSpace()
.IsGuid();
```

Easily extendable:

```csharp
public static class StringArgExtensions
{
    public static StringParam IsNotFishy(this StringParam param)
        => param.Value != "fishy"
            ? param
            : throw Ensure.ExceptionFactory.ArgumentException("Something is fishy!", param.Name);
}

Ensure.That(myString, nameof(myString)).IsNotFishy();
```

**NOTE:** If you are worried that the constructed `public readonly struct Param<T> {}` created for the argument being validated will hurt your performance you can use any of the other constructs e.g. contextual `Ensure.String` or `EnsureArg` (see below for samples).

## Ensure.Context - Using contextual validation
Introduced in the `v7.0.0` release.

```csharp
Ensure.String.IsNotNullOrWhiteSpace(myString);
Ensure.String.IsNotNullOrWhiteSpace(myString, nameof(myArg));
Ensure.String.IsNotNullOrWhiteSpace(myString, nameof(myArg), (in EnsureOptions opts) => opts.WithMessage("Foo"));
```

Easily extendable:

```csharp
public static class StringArgExtensions
{
    public static string IsNotFishy(this StringArg _, string value, string paramName = null)
        => value != "fishy"
            ? value
            : throw Ensure.ExceptionFactory.ArgumentException("Something is fishy!", paramName);
}

Ensure.String.IsNotFishy(myString, nameof(myString));
```

### EnsureArg - Using simple static methods
Introduced in the `v5.0.0` release.

```csharp
EnsureArg.IsNotNullOrWhiteSpace(myString);
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg), (in EnsureOptions opts) => opts.WithMessage("Foo"));
```

Easily extendable:

```csharp
public static partial class EnsureArg
{
    public static string IsNotFishy(string value, string paramName = null)
        => value != "fishy"
            ? value
            : throw Ensure.ExceptionFactory.ArgumentException("Something is fishy!", paramName);
}

EnsureArg.IsNotFishy(myString, nameof(myString));
```

## Samples
The Samples above just uses `string` validation, but there are more. E.g.:

* Strings
* Numerics
* Collections (arrays, lists, collections, dictionaries)
* Booleans
* Guids

## Get up and running with the source code #
The main solution is maintained using Visual Studio 2017.

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to:

- `Pull`
- `Compile`
- `Run the tests`

Easiest done using:

```
git clone ...
```

and

```
dotnet test src/Ensure.That.sln
```
