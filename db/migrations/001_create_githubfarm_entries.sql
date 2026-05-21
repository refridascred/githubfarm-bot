-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_active ON githubfarm_entries (active);

INSERT INTO githubfarm_entries (state, level, token, active) VALUES ('open', 11, 'standard', 94);
INSERT INTO githubfarm_entries (state, level, token, active) VALUES ('stable', 94, 'eu-west', 49);
