CityHash
========

.NET wrapper for Google's City Hash family of hash functions (<a href="http://code.google.com/p/cityhash/">http://code.google.com/p/cityhash/</a>).

Usage
========

This library exposes the City Hash functions as string extension methods.  Add the CityHash.dll as a reference to your .NET project, and place the CityHash.Win32.dll in a directory that your application can find.

    using CityHash;
    
    .
    .
    .
    
    string someString = "some string";
    
    // Generating a 32-bit hash
    someString.GetCityHash32(); //returns 805573804
    
    // Generating a 64-bit hash
    someString.GetCityHash64(); //returns 9651795998918897910
    
    // Generating a 64-bit hash with a seed
    someString.GetCityHash64(1234); //returns 2539580409082155169
    
    // Generating a 64-bit hash with two seeds
    someString.GetCityHash64(1234, 5678); //returns 5233622152544161018

Source Overview
========
The solution currently consists of the following projects:

<b>CityHash.Win32</b> - Port of the original CityHash source code to Win32

<b>CityHash</b> - Wrapper library that P/Invokes CityHash.Win32.dll for use in .NET

<b>CityHash.Tests</b> - Unit tests

TODO
========
* Implement Hash128 and Hash128WithSeed
* Eliminate CityHash.Win32.dll dependancy
* Create NuGet package

Contributing
========
Contributions and feedback are more than welcome.  Just fork, push, and send a pull request.
