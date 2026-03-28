-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_metric_events_region ON metric_events (region);

INSERT INTO metric_events (region, score, weight) VALUES ('local', 74.1, 35.57);
