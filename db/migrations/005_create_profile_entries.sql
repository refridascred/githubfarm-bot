-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_active ON profile_entries (active);

INSERT INTO profile_entries (active, region, state, score, level) VALUES (97, 'legacy', 'latest', 43.68, 0);
INSERT INTO profile_entries (active, region, state, score, level) VALUES (69, 'edge', 'green', 33.61, 53);
