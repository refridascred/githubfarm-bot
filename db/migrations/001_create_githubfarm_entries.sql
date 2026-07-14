-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_score ON githubfarm_entries (score);
