#!/usr/bin/env bash
# Check the payload data.
set -eu

log() {
    printf '%s\n' "$*"
}

PAYLOAD_LIMIT=250
log "limit is ${PAYLOAD_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
