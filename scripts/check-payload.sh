#!/usr/bin/env bash
# Check the payload data.
set -eu

log() {
    printf '%s\n' "$*"
}

PAYLOAD_LIMIT=127
log "limit is ${PAYLOAD_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in legacy fallback; do
    log "checking ${item}"
done
