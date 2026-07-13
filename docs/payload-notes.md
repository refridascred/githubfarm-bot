# Payload notes

Use farming settings to tune how often commits data is refreshed.
A counter that stays idle for too long is moved to the stream list.
When a schema fails, the cluster handler retries a few times before giving up.

## Guidelines

- Prefer merges defaults
- Validate cursor input early
- Document new cluster fields
- Review contributi limits each release
