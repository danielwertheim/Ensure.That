Semantic versioning is used. See http://semver.org for more info. Basically this means that version format is:
_v[Major].[Minor].[Patch]_ and as long as Major hasn't been bumped, you should be able to update without any breaking API changes.

## v6.0.0 - PRERELEASE

**[Changed]:** Now developed as a .NET Standard 1.1 project.

**[Changed]:** When using comparing validation checks, e.g.`Lt`, `Gt`, `Between` etc.; An `ArgumentOutOfRangeException` is thrown instead of an `ArgumentException`.

**[Changed]:** Comparable validations e.g. `Lt`, `Gt` etc.; are not tied to `struct` anymore. Only against `IComparable<T>`.

**[Changed]:** When using the `Ensure.That(arg)` construct, it allows you to use e.g `WithException(_ => new Exception("Foo"))`. This could be appended after an validation method e.g. `IsNotNull`. How-ever, doing so would not kick the custom exception factory as the call tree would get terminated before, in the `IsNotNull` method. From now on, you can not chain anything on the actual validation method.

**[New]:** Added JetBrain's attribute `[NoEnumeration]` on `IsNotNull` to get rid of warning. Thanks @megafinz


## v5.0.0 - 2016-10-08
**[New]:** Now using DotNetCore and targetting .NetStandard1.1 as well as "normal" .Net4.5-.Net4.6.1

**[New]:** New flavour of API added, with less overhead. See README.md for mor info. But basically:

```csharp
EnsureArg.IsNotNullOrEmpty(myString)
```

The old flavour is still in.

**[Removed]:** Source package. If you want it. It's in the repo.

**[Removed]:** Removed support for extracting the name for params using a compiled lambda. Only reason people want it is for refactoring friendlyness. Use `nameof(myparam)` instead.

**[New]:** `WithExtraMessageOf` now has an overload that takes the `Param<T>` as an arg so:

```csharp
Ensure
    .That(myString, nameof(myString))
    .WithExtraMessageOf(p => "Some more details")
    .IsNotNullOrEmpty();
```

**[Replaced]:** Construct where you could pass an extra `Throws argument`. This is now replaced with `WithException`.

```csharp
Ensure.That(myString, nameof(myString)).IsNotNullOrEmpty(throws => throws.Custom(...));
```

Becomes

```csharp
Ensure
    .That(myString, nameof(myString))
    .WithException(param => new Exception())
    .IsNotNullOrEmpty();
```

## v4.0.0 - 2015-11-24
**No API change**. The `dll` for pre-vNext has been renamed from `EnsureThat.vDinasour.dll` to `EnsureThat.dll`

## v3.3.0 - 2015-11-10
**[New]:** `Ensure.Off();` - Lets you turn off the validation.

## v3.2.0 - 2015-09-28
**[New]:** `Ensure.That(dictionary).ContainsKey("foo");`

**[New]:** `Ensure.That(array|list|collection).Any(i => i == x);`

## v3.1.1 - 2015-09-19
**[Fix]:** Issue #18 - now resolves correctly in `.net4.5|4.5.1|4.5.2`

**[Fix]:** Source package now marked as development dependency.

## v3.1.0 - 2015-08-30

**[New]:** Support for lambdas, [read more](https://github.com/danielwertheim/Ensure.That/wiki#using-lambdas)
```c#
Ensure.That(() => person.Name).IsNotNullOrEmpty();
```

**[Fix]:** Resolve now works correctly for .Net4.6 projects.

## v3.0.0 - 2015-08-22
API is fully backwards compatible. The reason for major bump of version is that the NuGet now caries two different assemblies that target different frameworks. Both are portable class libraries.

- `EnsureThat.vDinasour.dll` is the `v2.0.0` one, that targets .Net4.0+, WinRT, WinPhone, Silverlight and other old stuff.
- `EnsureThat.vNext.dll` is the new one, that targets .Net4.6+, Win10, AspNetCore5.

New features:
Determine custom exceptions to be thrown, instead of default `ArgumentException`, by using overload:

```
Ensure.That(value, ParamName)
      .IsNotNull(throws => throws.InvalidOperationException));
```

or

````
Ensure.That(value, ParamName)
      .IsNotNull(throws => throws.Custom(p => new Exception("Ooops"))));
```

## v2.0.0 - 2014-07-02
- [Fix]: Now using JetBrains annotation for `NoEnumeration` to get rid of warning about possible multiple enumeration of enumerable.
- [Change/New]: Now supporting e.g. `uint`by changing to having most compares are now against `IComparable<T> where T:struct` as mentioned here: https://github.com/danielwertheim/Ensure.That/issues/8
- [New]: New targets `.Net4+, Silverlight, Windows Phone, WinRT`
- [New]: `Ensure.That(array|collection|string).SizeIs(2)`
- [New]: `Ensure.That(int|decimal|...|).Is(1)`
- [New]: `Ensure.That(int|decimal|...|).IsNot(1)`
- [New]: `Ensure.That(string).IsEqualTo("foo")`
- [New]: `Ensure.That(string).IsNotEqualTo("foo")`
- [New]: You have always been able to chain validation, but for those who want it more readable you can add an `And()`: `Ensure.That(string).IsNotNull().SizeIs(2)` can now also be `Ensure.That(string).IsNotNull().And().SizeIs(2)`
