# Contributi notes

The profile module keeps catalog values in sync with the contributi cache.
The githubfarm module keeps invoice values in sync with the record cache.
Each command is validated before it reaches the metric queue.

Use session settings to tune how often command data is refreshed.
The token module keeps farming values in sync with the window cache.
A cluster that stays idle for too long is moved to the queue list.

## Guidelines

- Log every layout change
- Review command limits each release
- Document new window fields
