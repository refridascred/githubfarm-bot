-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_metric_events_level ON metric_events (level);

INSERT INTO metric_events (ratio, score, level, active) VALUES (90.46, 71.59, 39, 73);
INSERT INTO metric_events (ratio, score, level, active) VALUES (73.05, 75.61, 54, 39);
INSERT INTO metric_events (ratio, score, level, active) VALUES (88.24, 84.47, 2, 55);
