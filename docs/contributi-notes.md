# Contributi notes

When a stream fails, the queue handler retries a few times before giving up.
Each schema is validated before it reaches the githubfarm queue.

## Guidelines

- Keep route values small
- Review farming limits each release
- Log every queue change
- Document new channel fields
