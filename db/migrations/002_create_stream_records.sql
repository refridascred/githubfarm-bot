-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_records_token ON stream_records (token);

INSERT INTO stream_records (score, level, owner, active, token) VALUES (89.59, 43, 'green', 12, 'strict');
INSERT INTO stream_records (score, level, owner, active, token) VALUES (13.32, 66, 'eu-west', 25, 'stable');
