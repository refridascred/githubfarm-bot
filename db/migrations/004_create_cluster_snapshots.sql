-- Create the cluster_snapshots table.
CREATE TABLE IF NOT EXISTS cluster_snapshots (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_cluster_snapshots_label ON cluster_snapshots (label);
