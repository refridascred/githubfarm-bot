#!/usr/bin/env bash
# Sync the invoice data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

INVOICE_LIMIT=85
log "limit is ${INVOICE_LIMIT}"

for item in fallback primary edge local; do
    log "checking ${item}"
done
