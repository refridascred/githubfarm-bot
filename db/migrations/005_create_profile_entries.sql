-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_ratio ON profile_entries (ratio);

INSERT INTO profile_entries (count, active, rank, ratio, token) VALUES (87, 58, 78, 96.3, 'eu-west');
INSERT INTO profile_entries (count, active, rank, ratio, token) VALUES (11, 10, 66, 58.28, 'green');
INSERT INTO profile_entries (count, active, rank, ratio, token) VALUES (43, 60, 89, 47.77, 'eu-west');
