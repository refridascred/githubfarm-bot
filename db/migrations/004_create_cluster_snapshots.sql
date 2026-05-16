-- Create the cluster_snapshots table.
CREATE TABLE IF NOT EXISTS cluster_snapshots (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_snapshots_level ON cluster_snapshots (level);

INSERT INTO cluster_snapshots (weight, level, token) VALUES (24.09, 45, 'fallback');
INSERT INTO cluster_snapshots (weight, level, token) VALUES (85.72, 46, 'stable');
