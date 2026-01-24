# Week1TestClass — Project Notes

Project created as a learning exercise for basic C# syntax and object-oriented concepts.

Summary
- Small console app with an entry point in `Program.cs`.
- Demonstrates classes and members in the `CSharpSyntax` folder: `Car`, `Carz`, and `CSharpSyntax`.
- Contains additional examples in `ReferenceFolder` including `ReferenceClass.cs` and `TestDrive.cs`.

What was covered / taught
- Classes and objects: how to define classes (`Car`, `Carz`) and instantiate them.
- Properties and fields: using auto-properties and backing fields to store state.
- Constructors: creating and initializing objects with constructors.
- Methods: defining behavior on classes (e.g., simple methods to act on object state).
- Namespaces and project layout: organizing code under folders and namespaces.
- Project files: `Week1TestClass.csproj` and using `dotnet` to build/run the project.
- IDE/project artifacts: why files like `bin/`, `obj/`, and editor settings should be ignored (see `.gitignore`).

How to build and run
```powershell
dotnet build
dotnet run
```

Notes
- The `.gitignore` in this repo excludes build outputs, IDE settings, and OS files.
- Explore `CSharpSyntax/Car.cs` and `CSharpSyntax/Carz.cs` to review class definitions and examples.

If you want, I can:
- Commit these changes for you.
- Expand this README with code snippets or a short walkthrough of `Car` and `Carz` examples.
