-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_metric_events_score ON metric_events (score);

INSERT INTO metric_events (weight, level, owner, count, score) VALUES (86.65, 78, 'strict', 43, 78.97);
