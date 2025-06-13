# AspNetCore-DependencyInjection-CompleteGuide
A simple ASP.NET Core project showcasing DI lifetimes, service scopes, and multiple injection methods.
#  Dependency Injection Playground - ASP.NET Core

This is a simple ASP.NET Core project created to **demonstrate and explore Dependency Injection (DI)** and related concepts using real implementations and examples.

---

## What’s Implemented in This Project

### 1. **Dependency Injection Basics**
- Registered interfaces with implementations using `AddTransient`, `AddScoped`, and `AddSingleton`.

### 2. **IoC (Inversion of Control)**
- Complete separation between abstraction and implementation to follow IoC principles.

### 3. **Service Injection Techniques**
- Constructor Injection (default)
- Method Injection using `[FromServices]` attribute
- View Injection using `@inject` in Razor views

### 4. **Service Lifetimes**
- **Transient:** New instance on every request
- **Scoped:** One instance per HTTP request
- **Singleton:** One shared instance throughout application lifetime

### 5. **Service Scope (Manual Scope Creation)**
- Demonstrated how to create service scope manually using `IServiceScopeFactory` (useful for background tasks or hosted services)

---

## Technologies Used
- ASP.NET Core
- C#
- Visual Studio 2022 / VS Code
- .NET 8+

---

## Project Structure
- `Services/` → Contains interface and implementation classes
- `Controllers/` → Show how services are injected
- `Views/` → Shows usage of `@inject`
- `Program.cs` → DI registration and setup

---

## How to Run
```bash
dotnet run
