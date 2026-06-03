# Shopping Cart API

A .NET 8 shopping cart backend built with Clean Architecture, inspired by the patterns from Steve "Ardalis" Smith and Casey Crouse.

The focus here is maintainability and testability: keep business logic free from framework dependencies, use specifications for query logic, and run integration tests against a real database instead of in-memory fakes.

## Architecture & Layout

* **Core:** Entities (`Cart`, `CartItem`, `Money`), specifications, guard clauses, domain events, and interfaces. No external dependencies.
* **Infrastructure:** Database logic via EF Core, migrations, repositories, and third-party integrations (payments, notifications).
* **Web:** ASP.NET Core Minimal APIs for simple routes, with MediatR handlers used for complex multi-step commands.
* **IntegrationTests:** End-to-end API tests using `WebApplicationFactory` and Testcontainers.

```text
src/
├── Core/
├── Infrastructure/
└── Web/
tests/
└── IntegrationTests/