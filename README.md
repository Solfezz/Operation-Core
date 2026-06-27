# Solfezz Operations Core

Solfezz Operations Core is a C#/.NET portfolio project that models internal business operations workflows for SKU management, inventory movement, order allocation, backorders, fulfillment status, kit/BOM availability, and operational reporting.

This project is based on prior production experience building custom PHP/MySQL business workflow systems and is being rebuilt as a modern ASP.NET Core API to demonstrate current C#/.NET backend development capability.

## Planned Tech Stack

- C#
- .NET 10
- ASP.NET Core Web API
- EF Core
- SQLite / SQL Server
- xUnit
- Integration tests
- E2E API tests
- Docker
- GitHub Actions
- Swagger / OpenAPI

## Planned Business Workflow

```text
Order created
  -> SKU lines validated
  -> Inventory checked
  -> Stock allocated
  -> Backorders created if stock is short
  -> Fulfillment status updated
  -> Shipment tracking recorded
  -> Operational reports generated