-- Create the cluster_snapshots table.
CREATE TABLE IF NOT EXISTS cluster_snapshots (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_snapshots_ratio ON cluster_snapshots (ratio);
