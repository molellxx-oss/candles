param()
if (!(Test-Path -Path ".env")) {
  Copy-Item .env.example .env
  Write-Host "Copied .env.example to .env — edit .env if needed"
}

docker compose up --build -d
Write-Host "Services started. App: http://localhost:8080, MailDev: http://localhost:1080"
Write-Host "To follow logs: docker compose logs -f"
