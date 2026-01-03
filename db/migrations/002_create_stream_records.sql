-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_records_level ON stream_records (level);

INSERT INTO stream_records (token, label, level) VALUES ('fallback', 'green', 11);
