-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_region ON githubfarm_entries (region);
