# C# Console Kata Boiler

### Intent
Somewhat simple boilerplate for C# katas and exercises in the console. 

- Auto resolved transient dependencies following MS interface naming conventions: ``` class Example : IExample ```.
- Unit Tests (mocked dependencies).
- Component Tests (resolves real dependencies with option to fake as needed).
- Test helpers for AAA testing vernacular.

### Running The Tests
- ``` Rider > CTRL+T, L ```
- ``` Terminal > dotnet test ```

### Project Dependencies

*ConsoleClient*
- Microsoft.Extension.DependencyInjection
- Scrutor

*Tests*
- AutoMoq
- FluentAssertions
- Microsoft.Extension.DependencyInjection
- Moq
- NUnit