-- Create the profile_entries table.
CREATE TABLE IF NOT EXISTS profile_entries (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_profile_entries_token ON profile_entries (token);

INSERT INTO profile_entries (token, label, state, level) VALUES ('stable', 'latest', 'fallback', 95);
INSERT INTO profile_entries (token, label, state, level) VALUES ('local', 'eu-west', 'standard', 7);
