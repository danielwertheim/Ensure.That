# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments.

```csharp
Ensure.That(myString, "myString").IsNotNullOrWhiteSpace();
```

You can also easily extend it to use `lambdas`. Please note though, that you will lose performance, but look in the wiki and I'll show you how to enable it:

```csharp
Ensure.That(() => myString).IsNotNullOrWhiteSpace()
```

## Release notes ##
Available from `v2.0.0`, https://github.com/danielwertheim/Ensure.That/wiki/Release-notes

## Portable libary or Source via NuGet #
Ensure.That is distributed via NuGet. Either [as a portable library](http://nuget.org/packages/ensure.that) (`for .Net4+, Silverlight, Windows Phone, WinRT`) or as [an includable source package](http://nuget.org/packages/ensure.that.source).

## Documentation ##
The documentation is contained in the [project wiki](https://github.com/danielwertheim/ensure.that/wiki).

# Get up and running with the source code #
The main solution is maintained using Visual Studio 2013, but you should be able to use Visual Studio 2012, targetting multiple platforms using a portable class library (PCL).

Please note. **No NuGet packages are checked in**. If you are using the latest version of NuGet (v2.7.1+) **you should be able to just build and the packages will be restored**. If this does not work, you could install the missing NuGet packages using a simple PowerShell script [as covered here](http://danielwertheim.se/2013/08/12/nuget-restore-powershell-vs-rake)

Unit-tests are written using `xUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`.

## How-to Contribute ##
This is described in the wiki, under: ["How-to Contribute"](https://github.com/danielwertheim/Ensure.That/wiki/how-to-contribute).

Pull request should be against the `develop` **branch**

## Issues, questions, etc ##
So you have issues or questions... Great! That means someone is using it. Use the issues function here at the project page or contact me via mail: firstname@lastname.se; or Twitter: [@danielwertheim](https://twitter.com/danielwertheim)

## License ##
The MIT License (MIT)

Copyright (c) 2013 Daniel Wertheim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.