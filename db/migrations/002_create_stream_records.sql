-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_records_region ON stream_records (region);
