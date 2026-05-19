-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_metric_events_label ON metric_events (label);

INSERT INTO metric_events (region, label) VALUES ('open', 'edge');
INSERT INTO metric_events (region, label) VALUES ('open', 'green');
