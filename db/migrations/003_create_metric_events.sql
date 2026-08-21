-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_metric_events_owner ON metric_events (owner);

INSERT INTO metric_events (owner, level) VALUES ('staging', 99);
INSERT INTO metric_events (owner, level) VALUES ('open', 87);
INSERT INTO metric_events (owner, level) VALUES ('local', 68);
