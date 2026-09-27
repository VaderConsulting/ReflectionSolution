# ReflectionSolution

Parallel C# and VB.NET learning solution. Each language has an abstract `Template` (and a small `MyInterface` / `Enumeration`), a derived class library that implements `MyProperty` and `PublicFunction`, and a WinForms host that constructs the class and sets Hello World. The C# host also sketches `Assembly.LoadFrom` type listing. An older copy of the same tree lived under `Old` and was not imported.

**Source last updated:** 2008-05-21  
**Language:** C# / VB.NET  
**Target:** .NET 2.0  
**Output:** two WinForms exes + class libraries

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `CSharpApplication` | C# | WinForms exe (.NET 2.0) | Hosts CSharpClass and sketches Assembly.LoadFrom |
| `CSharpClassLibrary` | C# | class library (.NET 2.0) | `CSharpClass` inheriting Template |
| `CSharpClassLibraryTemplate` | C# | class library (.NET 2.0) | Abstract Template, MyInterface, Enumeration |
| `VBApplication` | VB.NET | WinForms exe (.NET 2.0) | Hosts VBClass on Form1_Load |
| `VBClassLibrary` | VB.NET | class library (.NET 2.0) | `VBClass` inheriting Template |
| `VBClassLibraryTemplate` | VB.NET | class library (.NET 2.0) | Abstract Template, MyInterface, Enumeration |

## How to open

Open `ReflectionSolution.sln` in Visual Studio 2008 or later. Run CSharpApplication or VBApplication.

## Requirements

- Visual Studio 2008, .NET Framework 2.0

## Attribution and provenance

Working copy from my Historical Dev folder.

From my Historical Dev archive (folder `ReflectionSolution`). Assembly copyright 2008.

## License

MIT License. Copyright (c) 2026 VaderConsulting.
