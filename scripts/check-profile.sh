#!/usr/bin/env bash
# Check the profile data.
set -eu

log() {
    printf '%s\n' "$*"
}

PROFILE_LIMIT=191
log "limit is ${PROFILE_LIMIT}"

for item in cached strict; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
