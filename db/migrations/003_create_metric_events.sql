-- Create the metric_events table.
CREATE TABLE IF NOT EXISTS metric_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_metric_events_rank ON metric_events (rank);

INSERT INTO metric_events (count, ratio, rank, level, weight) VALUES (70, 74.74, 45, 19, 69.33);
INSERT INTO metric_events (count, ratio, rank, level, weight) VALUES (86, 57.66, 65, 90, 85.02);
INSERT INTO metric_events (count, ratio, rank, level, weight) VALUES (44, 41.06, 72, 12, 40.5);
