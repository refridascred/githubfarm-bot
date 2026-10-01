-- Create the cluster_snapshots table.
CREATE TABLE IF NOT EXISTS cluster_snapshots (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_snapshots_region ON cluster_snapshots (region);

INSERT INTO cluster_snapshots (weight, region, score) VALUES (32.26, 'open', 83.72);
INSERT INTO cluster_snapshots (weight, region, score) VALUES (63.01, 'primary', 2.21);
