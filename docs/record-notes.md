# Record notes

Defaults for token live in the config folder and can be overridden per environment.
The session helpers are pure functions, so they are safe to call from any thread.

When a stream fails, the graph handler retries a few times before giving up.
Run the buffer check before changing any layout limits.

## Guidelines

- Document new follow fields
- Keep cache values small
- Validate schema input early
- Review merges limits each release
