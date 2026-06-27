# Record notes

When a queue fails, the channel handler retries a few times before giving up.
Run the layout check before changing any layout limits.
Each filter is validated before it reaches the schema queue.

A filter that stays idle for too long is moved to the filter list.
Each farm is validated before it reaches the counter queue.

## Guidelines

- Review farming limits each release
- Keep commits values small
- Log every token change
- Validate layout input early
