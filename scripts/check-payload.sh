#!/usr/bin/env bash
# Check the payload data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-eu-west}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

PAYLOAD_LIMIT=331
log "limit is ${PAYLOAD_LIMIT}"
