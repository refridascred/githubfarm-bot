# Contributi notes

The cache report groups every record by repos.
Each stream is validated before it reaches the profile queue.
When a stream fails, the merges handler retries a few times before giving up.

Each contributi is validated before it reaches the layout queue.
The githubfarm report groups every farm by repos.

## Guidelines

- Review repos limits each release
- Keep invoice values small
- Validate metric input early
- Prefer queue defaults
