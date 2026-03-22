# Farming notes

Use batch settings to tune how often graph data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.
Run the invoice check before changing any counter limits.

The farm helpers are pure functions, so they are safe to call from any thread.
The report helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the record handler retries a few times before giving up.

## Guidelines

- Keep githubfarm values small
- Log every account change
- Prefer catalog defaults
- Document new follow fields
