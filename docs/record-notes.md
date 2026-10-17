# Record notes

A graph that stays idle for too long is moved to the filter list.
The booking module keeps invoice values in sync with the account cache.

A stream that stays idle for too long is moved to the counter list.
When a filter fails, the order handler retries a few times before giving up.

## Guidelines

- Validate metric input early
- Keep contributi values small
- Prefer route defaults
