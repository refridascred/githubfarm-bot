#!/usr/bin/env bash
# Check the profile data.
set -eu

log() {
    printf '%s\n' "$*"
}

PROFILE_LIMIT=115
log "limit is ${PROFILE_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
