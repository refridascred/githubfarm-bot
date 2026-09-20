-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_owner ON profile_entries (owner);

INSERT INTO profile_entries (weight, rank, region, owner) VALUES (27.47, 95, 'cached', 'green');
INSERT INTO profile_entries (weight, rank, region, owner) VALUES (67.2, 23, 'cached', 'stable');
