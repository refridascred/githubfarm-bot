-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_metric_events_label ON metric_events (label);

INSERT INTO metric_events (region, score, label, count, rank) VALUES ('staging', 58.77, 'standard', 35, 45);
