-- Create the cluster_snapshots table.
CREATE TABLE IF NOT EXISTS cluster_snapshots (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_cluster_snapshots_score ON cluster_snapshots (score);

INSERT INTO cluster_snapshots (score, region, label, state) VALUES (27.59, 'edge', 'staging', 'stable');
INSERT INTO cluster_snapshots (score, region, label, state) VALUES (98.29, 'blue', 'latest', 'green');
INSERT INTO cluster_snapshots (score, region, label, state) VALUES (80.43, 'fallback', 'primary', 'latest');
