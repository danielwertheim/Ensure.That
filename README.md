# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

It's developed for .NET Standard 1.1 and .NET Standard 2.0 and available on [NuGet](https://www.nuget.org/packages/ensure.that/).

### Using static simple methods
The `EnsureArg` flavour was added in the `v5.0.0` release and **this is my prefered way**, because it has less overhead (read more below) and is the API that will continue to exist.

```csharp
EnsureArg.IsNotNullOrWhiteSpace(myString);
EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
```

the value is passed through so that you e.g. can assign it to a field:

```csharp
_field1 = EnsureArg.IsNotNullOrWhiteSpace(myString);
_field2 = EnsureArg.IsNotNullOrWhiteSpace(myString, nameof(myArg));
```

### Using extension methods
Since `v7.0.0` the `Ensure.That` flavour below has been marked as **`Obsolete`** with a warning and will be removed in the next major version (`v8.0.0`).

This is the initial way of doing validation, but **this IS NOT my prefered way**. Why? Well because it will
create a new instance of `Param<T>` wrapping the value being passed, so that the context-aware extension
methods can target correct type. *Imagine doing this in a loop on a multitude of instances...*

```csharp
//PLEASE NOTE. This will be depricated in v8.0.0 in favour for EnsureArg.Is...()

Ensure.That(myString).IsNotNullOrWhiteSpace();
Ensure.That(myString, nameof(myArg)).IsNotNullOrWhiteSpace();
```

```csharp
//PLEASE NOTE. This will be depricated in v8.0.0 in favour for EnsureArg.Is...()

Ensure
    .That(myString, nameof(myString))
    .WithExtraMessageOf(p => "Some more details")
    .IsNotNullOrWhiteSpace();
```

```csharp
//PLEASE NOTE. This will be depricated in v8.0.0 in favour for EnsureArg.Is...()

Ensure
    .That(myString, nameof(myString))
    .WithException(param => new Exception())
    .IsNotNullOrEmpty();
```

## Turn On/Off - default is On
Could be used with different profiles. Like `Debug` and `CI` is `On` while `Release` is `Off`.

```csharp
#if RELEASE
    Ensure.Off()
#endif
```

## Samples
The Samples above just uses `string` validation, but there are more. E.g.:

* Strings
* Numerics
* Collections (arrays, lists, collections, dictionaries)
* Booleans
* Guids

# Get up and running with the source code #
The main solution is maintained using Visual Studio 2017.

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`:

```
dotnet test
```
