-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_metric_events_token ON metric_events (token);

INSERT INTO metric_events (token, region, owner, active, count) VALUES ('open', 'stable', 'green', 7, 80);
INSERT INTO metric_events (token, region, owner, active, count) VALUES ('latest', 'latest', 'eu-west', 83, 78);
