-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_weight ON githubfarm_entries (weight);

INSERT INTO githubfarm_entries (rank, weight, ratio) VALUES (50, 33.47, 90.55);
