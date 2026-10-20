-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_active ON githubfarm_entries (active);

INSERT INTO githubfarm_entries (label, active, region, owner) VALUES ('stable', 25, 'latest', 'green');
INSERT INTO githubfarm_entries (label, active, region, owner) VALUES ('stable', 41, 'blue', 'open');
