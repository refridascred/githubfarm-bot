-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_ratio ON githubfarm_entries (ratio);

INSERT INTO githubfarm_entries (ratio, label) VALUES (14.36, 'blue');
INSERT INTO githubfarm_entries (ratio, label) VALUES (22.81, 'latest');
INSERT INTO githubfarm_entries (ratio, label) VALUES (59.97, 'open');
