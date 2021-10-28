# C# Console Kata Boiler

### Intent
Somewhat simple boilerplate for C# katas and exercises in the console. 

- Unit Tests (mocked dependencies)
- Component Tests (resolves real dependencies with option to fake as needed)
- Auto resolved transient dependencies following MS interface naming conventions: ``` class Example : IExample ```

### Running The Tests
- ``` Rider > CTRL+T, L ```
- ``` Terminal > dotnet test ```

