# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

It's developed for .NET 4.5.1 as well as .NET Standard 1.1 and .NET Standard 2.0 and available via [NuGet](https://www.nuget.org/packages/ensure.that/).

[![Build Status](https://dev.azure.com/danielwertheim/ensure.that/_apis/build/status/danielwertheim.Ensure.That?branchName=master)](https://dev.azure.com/danielwertheim/ensure.that/_build/latest?definitionId=22&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/ensure.that.svg)](http://nuget.org/packages/ensure.that)

## Using extension methods
This was supposed to be removed but after some wishes from the community it has been kept it with some slight changes.

If you are worried that the constructed `public struct Param<T> {}` created for the argument being validated will hurt your performance you can use any of the other constructs e.g. contextual `Ensure.String` or `EnsureArg`.

```csharp
Ensure.That(myString).IsNotNullOrWhiteSpace();
Ensure.That(myString, nameof(myArg)).IsNotNullOrWhiteSpace();
Ensure.That(myString, nameof(myArg), opts => opts.WithMessage("Foo")).IsNotNullOrWhiteSpace();
```

## Using contextual validation
This flavour was introduced in the `v7.0.0` release.

```csharp
Ensure.String.IsNotNullOrWhiteSpace(myString);
Ensure.String.IsNotNullOrWhiteSpace(myString, nameof(myArg));
Ensure.String.IsNotNullOrWhiteSpace(myString, nameof(myArg), opts => opts.WithMessage("Foo"));
```
### Using static simple methods
The `EnsureArg` flavour was added in the `v5.0.0` release.

```csharp
EnsureArg.IsNotNullOrWhiteSpace(myString);
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg), opts => opts.WithMessage("Foo"));
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
