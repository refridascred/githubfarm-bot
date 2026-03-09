# Payload notes

Each record is validated before it reaches the metric queue.
Run the metric check before changing any ticket limits.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every route change
- Review booking limits each release
- Validate graph input early
