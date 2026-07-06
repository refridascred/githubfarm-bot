-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_records_token ON stream_records (token);
