#!/usr/bin/env bash
# Sync the invoice data.
set -eu

log() {
    printf '%s\n' "$*"
}

INVOICE_LIMIT=100
log "limit is ${INVOICE_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in eu-west green stable; do
    log "checking ${item}"
done
