#!/usr/bin/env bash
# Sync the invoice data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in standard local; do
    log "checking ${item}"
done

INVOICE_LIMIT=275
log "limit is ${INVOICE_LIMIT}"
