#!/usr/bin/env bash
# Check the profile data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in edge local; do
    log "checking ${item}"
done
