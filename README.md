# Min

> Side-project personnel — portfolio

## Stack

| Couche | Technologie |
|---|---|
| Backend | ASP.NET Core 10 |
| Frontend | Blazor WebAssembly |
| Orchestration (dev) | .NET Aspire |
| Authentification | Keycloak |
| Base de données | PostgreSQL |

## Prérequis

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [JetBrains Rider](https://www.jetbrains.com/rider/)

## Lancer le projet en local

```bash
# Cloner le repo
git clone https://github.com/<ton-username>/Min.git
cd Min

# Démarrer l'orchestration Aspire (lance PostgreSQL, Keycloak, backend et frontend)
dotnet run --project AppHost
```

## Structure

```
Min/
├── backend/        # ASP.NET Core Web API
├── frontend/       # Blazor WebAssembly
├── AppHost/        # Aspire - orchestration
└── ServiceDefaults/ # Aspire - configuration partagée
```