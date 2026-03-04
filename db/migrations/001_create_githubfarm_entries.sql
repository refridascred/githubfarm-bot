-- Create the githubfarm_entries table.
CREATE TABLE IF NOT EXISTS githubfarm_entries (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_githubfarm_entries_owner ON githubfarm_entries (owner);

INSERT INTO githubfarm_entries (owner, region, rank) VALUES ('latest', 'blue', 51);
INSERT INTO githubfarm_entries (owner, region, rank) VALUES ('fallback', 'latest', 2);
INSERT INTO githubfarm_entries (owner, region, rank) VALUES ('primary', 'staging', 99);
