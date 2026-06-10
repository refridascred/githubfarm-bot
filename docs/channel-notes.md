# Channel notes

Each catalog is validated before it reaches the repos queue.
Use schema settings to tune how often repos data is refreshed.
Each route is validated before it reaches the githubfarm queue.

The context module keeps farm values in sync with the buffer cache.
The graph helpers are pure functions, so they are safe to call from any thread.
The cluster report groups every session by ticket.

## Guidelines

- Prefer token defaults
- Log every graph change
- Keep farming values small
- Document new booking fields
