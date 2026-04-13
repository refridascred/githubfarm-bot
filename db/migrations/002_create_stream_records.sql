-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_records_level ON stream_records (level);
