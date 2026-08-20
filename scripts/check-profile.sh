#!/usr/bin/env bash
# Check the profile data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local staging cached; do
    log "checking ${item}"
done

PROFILE_LIMIT=112
log "limit is ${PROFILE_LIMIT}"
