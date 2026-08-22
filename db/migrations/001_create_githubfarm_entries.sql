-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_state ON githubfarm_entries (state);

INSERT INTO githubfarm_entries (rank, ratio, state) VALUES (76, 93.74, 'primary');
INSERT INTO githubfarm_entries (rank, ratio, state) VALUES (4, 61.04, 'staging');
INSERT INTO githubfarm_entries (rank, ratio, state) VALUES (70, 24.48, 'edge');
