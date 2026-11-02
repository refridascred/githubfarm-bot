-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_state ON profile_entries (state);

INSERT INTO profile_entries (state, rank, score) VALUES ('edge', 47, 66.72);
