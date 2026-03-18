-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_label ON githubfarm_entries (label);

INSERT INTO githubfarm_entries (weight, label, token) VALUES (10.57, 'staging', 'eu-west');
