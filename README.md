# REST API endpoint with [template](https://github.com/jasontaylordev/CleanArchitecture)

Made entirely on *Linux* and *Visual Studio Code*, with
*no previous experience* of C# and its ecosystem. Hopefully it runs on
*Widows* also.

Unfortunately, I didn't get the tests to work on Linux. I tried with:
- **LocalDB**
> LocalDB is not supported on this platform.
- **In memory database**
> Relational-specific methods can only be used when the context is using a relational database provider.
- **SQLite**
> I think i had path/connection string problem.

## How To Run It

In project root

```
cd src/WebUI
dotnet run
```

Navigate to https://localhost:5001/api
