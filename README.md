# Candles (improvements/full-refactor)

This branch contains build assets and run scripts to start the project locally (Docker and local dotnet run).

Quick start (Docker - recommended):

1. Copy .env.example to .env and fill values if needed.
2. Run:

   docker compose up --build

3. Open http://localhost:8080
4. Mail dev UI: http://localhost:1080

Quick start (without Docker):

1. Ensure .NET 8 SDK is installed.
2. Open a terminal in the project root and run:

   dotnet restore
   dotnet run --project Minimarketplace.Web

Files added in this commit:
- docker-compose.yml (app + postgres + maildev)
- Dockerfile (build/publish image)
- run.sh / run.ps1
- .env.example

If you want nightly/full feature commits as zip files, I will provide branch zip links after each major milestone.
