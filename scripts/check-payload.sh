#!/usr/bin/env bash
# Check the payload data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green primary; do
    log "checking ${item}"
done

PAYLOAD_LIMIT=6
log "limit is ${PAYLOAD_LIMIT}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
