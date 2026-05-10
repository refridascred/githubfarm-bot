#!/usr/bin/env bash
# Check the payload data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in legacy local standard; do
    log "checking ${item}"
done
