#!/usr/bin/env bash
# Check the payload data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue eu-west; do
    log "checking ${item}"
done

PAYLOAD_LIMIT=276
log "limit is ${PAYLOAD_LIMIT}"
