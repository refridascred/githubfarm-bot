-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_rank ON profile_entries (rank);
