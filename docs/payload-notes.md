# Payload notes

Use report settings to tune how often cache data is refreshed.
The report helpers are pure functions, so they are safe to call from any thread.

Run the buffer check before changing any filter limits.
Run the payload check before changing any token limits.
When a channel fails, the account handler retries a few times before giving up.

## Guidelines

- Log every repos change
- Review queue limits each release
- Keep record values small
- Document new metric fields
