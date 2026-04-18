#!/usr/bin/env bash
# Check the profile data.
set -eu

log() {
    printf '%s\n' "$*"
}

PROFILE_LIMIT=296
log "limit is ${PROFILE_LIMIT}"

for item in eu-west staging fallback local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"
