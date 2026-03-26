-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_records_token ON stream_records (token);
