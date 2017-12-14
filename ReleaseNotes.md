Semantic versioning is used. See http://semver.org for more info. Basically this means that version format is:
_v[Major].[Minor].[Patch]_ and as long as Major hasn't been bumped, you should be able to update without any breaking API changes.

## v7.2.0 - 2017-12-14

**[New]:** Added overload to `EnsureArg` and contextual e.g. `Ensure.StringArg` that allows you to define either a custom exception message or custom exception.

**[New]:** Added `Ensure.Enumerable` which provides the members found in `Ensure.Collection` but it operates on `IEnumerable<T>` instead. **Please note that enumeration will occur**.

## v7.1.0 - 2017-11-19
Thanks to [@ndrwrbgs](https://github.com/ndrwrbgs) who has made this release happen. Lots of improvements when it comes to using Ensure.That with ReSharper etc.

**[Fix]:** `SizeIs` did not compare against `Array.LongLength` when passed a `long`.

**[New]:** Added more attributes to the API to get ReSharper to "understand" Ensure.That better.

**[New]:** Methods that are comparing values now accepts an optional `IComparer<T>`


## v7.0.0 - 2017-11-09

**[Obsolete warning]:** The "fluent" `Ensure.That` syntax has been marked as `Obsolete` in favour for either the contextual validations: `Ensure.String.IsNotNull(..., ...);` or `EnsureArg.IsNotNull(..., ...);` The obsolete versions will be removed in next major version.

**[New]:** Multiple target frameworks: `net4.5.1` and `netstandard1.1` and `netstandard2.0`

**[New]:** Contextual validation, e.g. `Ensure.String.IsNotNull(myString, nameof(myString));`

**[New]:** When using `EnsureArg`, the param being evaluated is now decorated with JetBrains `NotNullAttribute` and custom `ValidatedNotNull` (to get rid of `CA1062`).

**[New]:** `Any` for dictionaries.

**[New]:** `HasItems` for `IReadOnlyCollection` and `IReadOnlyList`.

**[New]:** `EnsureArg.Abcdefg(...)` methods now returns the value so that it can be assigned to e.g. fields: `_field = EnsureArg.IsNotNull(myArg, nameof(myArg))`.

**[Changed]:** Where applicable, validation methods now ensures that the param `IsNotNull`. If it is, an `ArgumentNullException` is thrown. So there is no need to do both. How-ever, some calls are not applicable to this, like `EnsureArg.IsNotEmpty(myString)`.

## v6.0.1 - 2017-10-04

**[Fix]:** Corrected assembly name to be same as previous: `Ensure.That.dll` instead of `EnsureThat.dll`

## v6.0.0 - 2017-09-19

**[Changed]:** Now developed as only a .NET Standard 1.1 project.

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
