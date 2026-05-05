-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_records_region ON stream_records (region);

INSERT INTO stream_records (count, state, score, region) VALUES (70, 'green', 71.79, 'open');
INSERT INTO stream_records (count, state, score, region) VALUES (83, 'edge', 78.76, 'staging');
INSERT INTO stream_records (count, state, score, region) VALUES (40, 'fallback', 27.93, 'latest');
