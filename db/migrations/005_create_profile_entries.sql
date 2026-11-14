-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_level ON profile_entries (level);
