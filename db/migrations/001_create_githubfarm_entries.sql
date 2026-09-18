-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_region ON githubfarm_entries (region);

INSERT INTO githubfarm_entries (token, region, state) VALUES ('latest', 'edge', 'primary');
