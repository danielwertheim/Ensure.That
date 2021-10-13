# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

It's developed for .NET Standard 2.0 and 2.1 available via [NuGet](https://www.nuget.org/packages/ensure.that/).

[![Build Status](https://dev.azure.com/daniel-wertheim/os/_apis/build/status/Ensure.That-CI?branchName=master)](https://dev.azure.com/daniel-wertheim/os/_build/latest?definitionId=1&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/ensure.that.svg)](http://nuget.org/packages/ensure.that)

## Using extension methods

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

**NOTE:** If you are worried that the constructed `public readonly struct Param<T> {}` created for the argument being validated will hurt your performance you can use any of the other constructs e.g. contextual `Ensure.String` or `EnsureArg` (see below for samples).

## Using contextual validation
Introduced in the `v7.0.0` release.

```csharp
Ensure.String.IsNotNullOrWhiteSpace(myString);
Ensure.String.IsNotNullOrWhiteSpace(myString, nameof(myArg));
Ensure.String.IsNotNullOrWhiteSpace(myString, nameof(myArg), (in EnsureOptions opts) => opts.WithMessage("Foo"));
```

### Using static simple methods
Introduced in the `v5.0.0` release.

```csharp
EnsureArg.IsNotNullOrWhiteSpace(myString);
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg), (in EnsureOptions opts) => opts.WithMessage("Foo"));
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
