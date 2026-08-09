-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_owner ON profile_entries (owner);

INSERT INTO profile_entries (score, weight, count, owner) VALUES (78.06, 49.91, 49, 'strict');
INSERT INTO profile_entries (score, weight, count, owner) VALUES (20.29, 43.51, 80, 'stable');
INSERT INTO profile_entries (score, weight, count, owner) VALUES (84.79, 47.28, 98, 'edge');
