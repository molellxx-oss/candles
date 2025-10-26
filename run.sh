#!/usr/bin/env bash
set -e
if [ ! -f .env ]; then
  cp .env.example .env
  echo "Copied .env.example to .env — edit .env if needed"
fi

docker compose up --build -d

echo "Services started. App: http://localhost:8080, MailDev: http://localhost:1080"
echo "To follow logs: docker compose logs -f"
