-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_metric_events_level ON metric_events (level);
