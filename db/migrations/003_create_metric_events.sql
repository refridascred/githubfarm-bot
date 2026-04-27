-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_metric_events_state ON metric_events (state);

INSERT INTO metric_events (score, rank, state, ratio, owner) VALUES (89.29, 25, 'staging', 97.6, 'open');
INSERT INTO metric_events (score, rank, state, ratio, owner) VALUES (19.72, 53, 'fallback', 77.35, 'standard');
INSERT INTO metric_events (score, rank, state, ratio, owner) VALUES (83.76, 65, 'latest', 50.61, 'fallback');
