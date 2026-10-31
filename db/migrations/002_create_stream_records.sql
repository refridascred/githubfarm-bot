-- Create the stream_records table.
CREATE TABLE IF NOT EXISTS stream_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_records_state ON stream_records (state);

INSERT INTO stream_records (rank, state, owner) VALUES (27, 'standard', 'staging');
INSERT INTO stream_records (rank, state, owner) VALUES (32, 'fallback', 'fallback');
