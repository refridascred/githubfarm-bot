#!/usr/bin/env bash
# Check the profile data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"

PROFILE_LIMIT=219
log "limit is ${PROFILE_LIMIT}"
