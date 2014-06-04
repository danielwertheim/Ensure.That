# Ensure.That
Ensure.That is a simple guard clause argument validation lib, that helps you with validation of your arguments. E.g. `Ensure.That(myString, "myString").IsNotNullOrWhiteSpace();` You can also easily extend it to use lambdas. Please note though, that you will lose performance, but look in the wiki and I'll show you how to enable: `Ensure.That(() => myString).IsNotNullOrWhiteSpace()`.

## Portable libary or Source via NuGet #
Ensure.That is distributed via NuGet. Either [as a portable library](http://nuget.org/packages/ensure.that) (`targetting .Net4+, Silverlight 4+, Windows Phone 7.5+, WindowsRT`) or as [an includable source package](http://nuget.org/packages/ensure.that.source).

## Documentation ##
The documentation is contained in the [project wiki](https://github.com/danielwertheim/ensure.that/wiki).

# Get up and running with the source code #
The Sample has been written using Visual Studio 2012, targetting multiple platforms using a portable class library (PCL). Please note: **No NuGet packages are checked in**. To get your project up and running you need to install the missing NuGet packages using the provided PowerShell script:

    ps:> .\setup-devenv.ps1

or

    cmd:> powershell -executionpolicy unrestricted .\setup-devenv.ps1

For the script to work, you need to have [the NuGet command line](http://nuget.codeplex.com/releases) `(NuGet.exe) registrered in the environment path`, or you need to tweak the script so it knows where it will find your NuGet.exe.

## Issues, questions, etc ##
So you have issues or questions... Great! That means someone is using it. Use the issues function here at the project page or contact me via mail: firstname@lastname.se; or Twitter: [@danielwertheim](https://twitter.com/danielwertheim)

## License ##
The MIT License (MIT)

Copyright (c) 2013 Daniel Wertheim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Contribute
Unit-tests are written using `NUnit` and there are no integration tests, hence you should just be able to: `Pull`-`Compile`&`Run the tests`.

Pull request should be against the **Develop branch**
