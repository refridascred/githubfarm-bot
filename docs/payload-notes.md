# Payload notes

The githubfarm report groups every githubfarm by invoice.
The bot helpers are pure functions, so they are safe to call from any thread.

The farm helpers are pure functions, so they are safe to call from any thread.
Use cluster settings to tune how often repos data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Review schema limits each release
- Document new farming fields
- Prefer contributi defaults
