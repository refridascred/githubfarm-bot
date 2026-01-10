# Farming notes

Use route settings to tune how often invoice data is refreshed.
Run the record check before changing any report limits.

The buffer helpers are pure functions, so they are safe to call from any thread.
The order report groups every buffer by metric.

## Guidelines

- Document new channel fields
- Log every farming change
- Prefer window defaults
- Review queue limits each release
