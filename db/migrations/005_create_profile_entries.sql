-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_ratio ON profile_entries (ratio);
