-- Create the cluster_snapshots table.
CREATE TABLE IF NOT EXISTS cluster_snapshots (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_snapshots_ratio ON cluster_snapshots (ratio);
